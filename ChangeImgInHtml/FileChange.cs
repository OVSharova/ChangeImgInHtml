using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ChangeImgInHtml
{
    public struct GroupClasses
    {
        public string GroupName { get; private set; }
        List<ImgVal> list;
        public GroupClasses(string groupName)
        {
            this.GroupName = groupName;
            list = new List<ImgVal>();
        }
        public bool IsEmpty()
        {
            return string.IsNullOrEmpty(this.GroupName);
        }
        public void Add(string str)
        {
            ImgVal img = new ImgVal(str);
            list.Add(img);
        }

        public IEnumerator<ImgVal> GetEnumerator() => list.GetEnumerator();
    }
    public struct ImgVal
    {
        public string FileName { get; private set; }
        public string ClassName { get; private set; }

        public ImgVal(string str)
        {
            this.ClassName = str;
            int index = str.IndexOf('-');
            this.FileName = str.Substring(index + 1) + ".png";
        }
    }
    public class ImgChange
    {
        
        List<GroupClasses> listImages;
        string[] files;
        bool withTip = false;
        int currentLine = 1;
        string fileCssPath;
        public string LogList { get; private set; }


        string currentFile, strLinkCss, oldLinkCss, pathName;
        public ImgChange(string pathName, string fileCssPath, string prefixCssLink, string oldLinkCss)
        {
            int index = fileCssPath.LastIndexOf('\\');
            this.listImages = MyFunctions.CreateList(fileCssPath);
            this.files = Directory.GetFiles(pathName, "*.htm", SearchOption.AllDirectories);
            this.oldLinkCss = oldLinkCss;
            this.fileCssPath = fileCssPath;
            if (prefixCssLink[prefixCssLink.Length - 1] != '/')
                prefixCssLink += "/";

            this.strLinkCss = "<link type = \"text/css\" rel = \"stylesheet\" href = \"";
            this.strLinkCss += prefixCssLink + fileCssPath.Substring(index+1);
            this.strLinkCss += "\" />";
            this.LogList = "";
            this.pathName = pathName;
        }

        public bool ChangeHtml(bool withTip = false)
        {
            try
            {
                this.withTip = withTip;
                string fileText;
            this.currentLine = 1;
                foreach (string file in this.files)
                {
                    
                    fileText = File.ReadAllText(file);
                    fileText = AddCssLink(fileText);
                    currentFile = file.Substring(pathName.Length);
                    foreach (GroupClasses gr in this.listImages)
                    {
                        foreach (ImgVal imgVal in gr)
                        {
                            fileText = PastDivsToFile(fileText, imgVal, gr.GroupName);
                        }
                    }
                    File.WriteAllText(file, fileText, Encoding.UTF8);

                }
                
                return true;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show(" Произошла ошибка в ChangeHtml", "Error!"
                    , System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
}
        public string AddCssLink(string text)
        {
            try
            {
                if (text.IndexOf(this.strLinkCss) != -1)
                {
                    this.LogList +="" + this.currentLine + ".\tВ файле " + this.currentFile + " уже есть ссылка на css для sprite\r\n";
                    this.currentLine++;
                    return text;
                }

                int index = text.IndexOf(this.oldLinkCss);
                int secondIndex = text.Substring(0, index).LastIndexOf('<');
                int firstIndex = text.Substring(0, secondIndex).LastIndexOf("\r\n");
                index = text.IndexOf('>', index);
                text = text.Substring(0, index + 1) +
                    text.Substring(firstIndex, secondIndex - firstIndex) +
                    this.strLinkCss +
                    text.Substring(index + 1);
                this.LogList += "" + this.currentLine + ".\tВ файл " + this.currentFile + " добавлена строка  < link type =\"text/css\" rel=\"stylesheet\" href=\"" + this.strLinkCss + "\" /> \r\n";
                this.currentLine++;
                return text;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Произошла ошибка в AddCssLink", "Error!"
                    , System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                this.LogList += "" + this.currentLine + ".\t" + this.currentFile + " Ошибка при добавлении ссылки на css файл\r\n";
                this.currentLine++;
                return text;
            }
        }

        private string AddTagA(string strImg, string strDiv)
        {
            int index = strImg.IndexOf("alt"), index2;
            if (index == -1) return strDiv;

            index = strImg.IndexOf("\"",index)+1;
            index2 = strImg.IndexOf("\"", index);
            return "<a title = \"" + strImg.Substring(index, index2 - index) + "\">" + strDiv + "</a>";
        }
        public bool DeleteImg()
        {
            try
            {
                this.currentLine =1;
                string[] imgs;
                string spriteDirectory = fileCssPath.Substring(0, fileCssPath.LastIndexOf('\\'));
                foreach (GroupClasses gr in listImages)
                {
                    foreach (ImgVal img in gr)
                    {
                        imgs = Directory.GetFiles(pathName, "" + img.FileName, SearchOption.AllDirectories);
                        foreach (string file in imgs)
                        {
                            if ((file.Length< spriteDirectory.Length)||(file.Substring(0, spriteDirectory.Length) != spriteDirectory))
                            {
                                File.Delete(file);
                                this.LogList += "" + this.currentLine + ".\tУдален файл " + file.Substring(pathName.Length)+"\r\n";
                                this.currentLine++;
                            }
                        }
                    }
                }
                return true;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show(" Произошла ошибка в DeleteImg", "Error!"
                    , System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                LogList += "" + this.currentLine + ".\tПроизошла ошибка в DeleteImg\r\n";
                this.currentLine++;
                return false;
            }


        }
        private string PastDivsToFile(string text, ImgVal img, string groupName)
        {
            int index = text.IndexOf("/" + img.FileName), beginindex, endIndex;
            string strDiv = "<div class = \"" + groupName +" " + img.ClassName + "\"></div>";
            while (index >-1)
            {
                beginindex = text.Substring(0, index).LastIndexOf('<') + 1;
                endIndex = text.IndexOf('>', index);
                if (this.withTip) 
                    strDiv = AddTagA(text.Substring(beginindex, endIndex - beginindex), strDiv);
                text = text.Substring(0, beginindex - 1) + strDiv + text.Substring(endIndex + 1);
                index = text.IndexOf("/" + img.FileName, beginindex);
                this.LogList += "" + this.currentLine + ".\tВ файл " + this.currentFile + " добавлена строка " + strDiv + "\r\n";
                this.currentLine++;

            }
            return text;
        }

    }
}
