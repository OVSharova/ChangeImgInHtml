using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ChangeImgInHtml
{
    class GeneralImg
    {
        const string dirImg = "images", srcGeneral = "../../../../../../common/main/resources/help", pathHelp = "\\main\\resorces\\help";

        string[] directories;
        string dirGeneralImages, currentDir;
        int currentLine;
        public string LogList { get; private set; }
        public GeneralImg(string dirImages)
        {
            directories = Directory.GetDirectories(dirImages);
            dirGeneralImages = dirImages;
            for (int i = 0; i < directories.Length; i++)
            {
                directories[i] = directories[i].Substring(dirGeneralImages.Length+1);
            }          

        }

        public void ChengeLinks(string path)
        {
            currentDir = path;
            string[] subDirs = Directory.GetDirectories(path);
            string nameDir;
            LogList = "";
            currentLine = 0;
            foreach (string subDir in subDirs)
            {
                nameDir = subDir.Substring(path.Length+1);
                if (nameDir != dirImg)
                    ChangeSrc(nameDir);
            }
        }
        public void DelteFiles(string path)
        {
            currentDir = path;
            string[] subDirs = Directory.GetDirectories(path);
            string nameDir;
            LogList = "";
            currentLine = 0;
            foreach (string subDir in subDirs)
            {
                nameDir = subDir.Substring(path.Length + 1);
                if (nameDir != dirImg)
                    DeliteFilesFromLeng(nameDir);
            }
        }
        private void DeliteFilesFromLeng(string leng)
        {
            string dirForDelited = currentDir + "\\" + leng+"\\" + dirImg, img;
            string dirGeneralImagesLeng = dirGeneralImages + "\\" + leng + "\\" + dirImg;
            string[] imgFiles = Directory.GetFiles(dirGeneralImagesLeng);            
            LogList += "Удаление файлов для " + leng + "\n";
            for (int i = 0; i < imgFiles.Length; i++)
            {
                img = imgFiles[i].Substring(dirGeneralImagesLeng.Length + 1);
                if (File.Exists(dirForDelited + "\\" + img))
                {
                    File.Delete(dirForDelited + "\\" + img);
                    LogList += "" + this.currentLine + ".\tУдален файл " + dirForDelited + "\\" + img  + "\r\n";
                }
            }
        }

        private void ChangeSrc(string leng)
        {
            string[] files = Directory.GetFiles(currentDir + "\\"+ leng, "*.htm", SearchOption.AllDirectories);
            string dirGeneralImagesLeng = dirGeneralImages + "\\" + leng + "\\" + dirImg;
            string[] imgFiles = Directory.GetFiles(dirGeneralImagesLeng);
            string fileText;
            
            for (int i=0;i<imgFiles.Length; i++)
            {
                imgFiles[i] = imgFiles[i].Substring(dirGeneralImagesLeng.Length+1);
            }
            int index, beginindex, endIndex=0;
            string strSrc;
            bool fixFile = false;
            LogList += "Замена ссылок на изображение для "+leng+"\n";
            foreach (string file in files)
            {
                fileText = File.ReadAllText(file);
                endIndex = 0;
                strSrc = srcGeneral + "/" + leng+"/" + dirImg + "/";
                fixFile = false;
                foreach (string img in imgFiles)
                {
                    index = fileText.IndexOf("/" +  img);
                    while(index>-1)
                    {
                        fixFile = true;
                        beginindex = fileText.Substring(0,index).LastIndexOf("..");
                        endIndex = fileText.IndexOf('"', index);
                        fileText = fileText.Substring(0, beginindex) + strSrc + img + fileText.Substring(endIndex);
                        currentLine++;
                        LogList += "" + this.currentLine + ".\tВ файле " + file + " заменена ссылка " + "../" + dirImg + "/" + img + " на " + strSrc + img+ "\r\n";
                        
                        index = fileText.IndexOf("/" + img, endIndex + strSrc.Length);                        
                    }
                }
                if(fixFile)
                    File.WriteAllText(file, fileText, Encoding.UTF8);
            }
            
        }
       
    }
}
