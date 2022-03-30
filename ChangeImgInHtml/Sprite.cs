using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;
using St = ChangeImgInHtml.Properties.Settings;

namespace ChangeImgInHtml
{
    enum SizeSprite { FixSize, AutomaticSize }
    class Sprite
    {
        Bitmap bmp;
        string path, spritePath;
        public string prefixClass, spName;
        int width = 800, height=0;
        string spriteFile;

        public string StrCss { get; private set; }
       

        public Sprite(string path, string spritePath,  string spriteFile = "sprite.png")
        {
             
            this.path = path;
            this.spritePath = spritePath;
            
            if (path == spritePath) {
                prefixClass = "." + St.Default.PrefixForSinglSprite;
                spName = St.Default.NameSinglePngSprite;
            }
            else {
                
                prefixClass = path.Substring(path.LastIndexOf('\\')+1);
                spName = prefixClass;
                prefixClass = "." + prefixClass;

            }
            this.spriteFile = spritePath + "\\" + spName + ".png";
            StrCss = prefixClass + " {\n" +
                "\tbackground-image: url(" + St.Default.PrfixPathSpitePng + "/" + spriteFile + ");\n" +
                "\tbackground-repeat: no-repeat;\n\tdisplay: inline-block;\n}\n\n";
            if (File.Exists(this.spriteFile))
                File.Delete(this.spriteFile);
        }

        public void CreateSprite()
        {
            
            Img[] imgList = CreateSpringList();
            using (var m = new MemoryStream())
            {   
                bmp = new Bitmap(width, height);
                bmp.MakeTransparent();
                Graphics graphics = Graphics.FromImage(bmp);
                foreach (Img img in imgList)
                {
                    graphics.DrawImage(img.ImgForBmp, img.X, img.Y, img.Width, img.Height);
                    StrCss += CssImg(img);
                }

                bmp.Save(spriteFile, System.Drawing.Imaging.ImageFormat.Png);
                
            }
        }

        string CssImg(Img img)
        {
            return prefixClass + "-" + img.ImgName + " {\n" +
                "\tbackground-position: -" + img.X + "px -" + img.Y + "px;\n" +
            "\twidth: " + img.Width + "px;\n" +
            "\theight: " + img.Height + "px;\n}\n\n";
        }
        private Img[] CreateSpringList()
        {
            int maxHeight = 0, currentX=0, currentY = 0;
            string[] imageFiles = Directory.GetFiles(path, "*.png" , SearchOption.AllDirectories);
            Img[] imgs = new Img[imageFiles.Length];

            for (int i = 0; i < imageFiles.Length; i++)
            {
                imgs[i] = new Img(imageFiles[i]);
            }
            Array.Sort(imgs);
            Array.Reverse(imgs);
            if ((SizeSprite)St.Default.sizeSprite == SizeSprite.FixSize)
            {
                for (int i = 0; i < imgs.Length; i++)
                {
                    if (currentX + imgs[i].Width > width)
                    {
                        currentX = 0;
                        if (currentX == 0 && imgs[i].Width > width)
                            width = imgs[i].Width;
                        currentY += maxHeight;
                        maxHeight = imgs[i].Height;
                    }
                    else if (maxHeight < imgs[i].Height)
                        maxHeight = imgs[i].Height;

                    imgs[i].X = currentX;
                    imgs[i].Y = currentY;

                    currentX += imgs[i].Width;

                }
                height = currentY + maxHeight;
            }
            else
            {
                GrowingPacker packer = new GrowingPacker(imgs);
                packer.fit();
                width = packer.root.Width;
                height = packer.root.Height;
                imgs = (Img[])packer.Blocks;
            }
                
            return imgs;
        }
        
    }
    

   
}
