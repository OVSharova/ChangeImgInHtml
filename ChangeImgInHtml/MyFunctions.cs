using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using St = ChangeImgInHtml.Properties.Settings;

namespace ChangeImgInHtml
{
    public static class MyFunctions
    {
        public static List<GroupClasses> CreateList(string fileName)
        {
            List<GroupClasses> listClasses = new List<GroupClasses>();
            string textCssFile= File.ReadAllText(fileName),str;
            int begintIndex = textCssFile.IndexOf("@")+1,
                endIndex = textCssFile.IndexOf('\n',begintIndex);
            begintIndex = textCssFile.IndexOf(".", endIndex) + 1;
            endIndex = textCssFile.IndexOf('{', begintIndex);
            GroupClasses gr = new GroupClasses(string.Empty);
            while (begintIndex >0)
            {
                str = textCssFile.Substring(begintIndex, endIndex - begintIndex).Trim();
                if (str.IndexOf('-') == -1)
                {
                    if (!gr.IsEmpty()) listClasses.Add(gr);
                    gr = new GroupClasses(str);
                }
                else
                    gr.Add(str);
                begintIndex = textCssFile.IndexOf(".", endIndex) + 1;
                endIndex = textCssFile.IndexOf('{', begintIndex);
            }
            if (!gr.IsEmpty()) listClasses.Add(gr);
            return listClasses;
        }
        public static string[] CreateListFiles(string dirPath)
        {
            
            string[] list = Directory.GetFiles(dirPath);
            for(int i = 0; i<list.Length;i++)
            {
                list[i] = list[i].Substring(dirPath.Length);
            }

            return list;
        }

       
        public static string CreateSprites(string path)
        {
            string[] paths = Directory.GetDirectories(path);
            string logStr = "";
            if (paths.Length == 0) paths = new string[] { path };
            Sprite sprite;
            string  cssPath = path + "\\" + St.Default.NameSpriteCSSFile + ".css";
            logStr += "СОЗДАНИЕ СПРАЙТОВ\r\n";
            int index = 1;
            if (File.Exists(cssPath))
            {
                File.Delete(cssPath);
                logStr += "" +index +".\tУдален существующий файл css\r\n";
                index++;
            }

            foreach(string dir in paths)
            {
                sprite = new Sprite(dir, path);
                sprite.CreateSprite();
                logStr += "" + index + ".\tСоздан  файл " + sprite.spName + ".png\r\n";
                index++;
                File.AppendAllText(cssPath, sprite.StrCss);
                logStr += "" + index + ".\tДобавлены классы с префисом " + sprite.prefixClass.Substring(1) + " в файл " + cssPath +"\r\n";
                index++;
            }
            return logStr;
        }
        
    }
   

}
