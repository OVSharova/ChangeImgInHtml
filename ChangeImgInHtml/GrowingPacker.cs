/**
 * the original code is at the link https://github.com/jakesgordon/bin-packing/blob/6c8ea72c9cd7904b57c3d0945363a5159d7cf6c5/js/packer.growing.js
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using St = ChangeImgInHtml.Properties.Settings;

namespace ChangeImgInHtml
{
    class Img : IComparable
    {
        public int X, Y;
        public int Width { get { return ImgForBmp.Width; } }
        public int Height { get { return ImgForBmp.Height; } }
        public Image ImgForBmp { get; private set; }
        public string ImgName { get; private set; }
        public Img(string path)
        {
            int ind1 = path.LastIndexOf('\\')+1, 
                ind2 = path.IndexOf('.', ind1);
            X = 0;
            Y = 0;
            ImgForBmp = Image.FromFile(path);
            ImgName = path.Substring(ind1, ind2 - ind1);
        }

      

        public static bool operator <(Img img1, Img img2)
        {
            if (img1.Height == img2.Height)
                return img1.Width < img2.Width;
            return img1.Height < img2.Height;
        }

        public Img(Img img)
        {
            X = img.X;
            Y = img.Y;
            this.ImgForBmp = img.ImgForBmp;
            ImgName = img.ImgName;

        }

        public static bool operator >(Img img1, Img img2)
        {
            if (img1.Height == img2.Height)
                return img1.Width > img2.Width;
            return img1.Height > img2.Height;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Img objImg = obj as Img;

            if (objImg == null)
                throw new ArgumentException("Object is not a Temperature");

            if (this > objImg)
                return 1;
            return this < objImg ? -1 : 0;
        }
    }

    class Fit
    {
        public bool Used = false;
        public Fit Down;
        public Fit Right;
        public Rectangle rect;
        public int X {get{return rect.X; }  }
        public int Y { get { return rect.Y; } }
        public int Height { get { return rect.Height; } }
        public int Width { get { return rect.Width; } }
        public Fit(int x, int y, int w, int h)
        {
            rect = new Rectangle(x, y, w, h);
            
        }
    }
    class Block  : Img
    {        
       
        public Fit FitImg {  
            set 
            {
                fit = value;
                
                    X =(value!=null)? fit.X : 0;
                    Y = (value != null) ? fit.Y : 0;
            }
            get
            {
                return fit;
            }
        }
        private Fit fit;

        public Block(string path) : base(path) { }
     
        public Block(Img img) : base(img) { }
    }
    class GrowingPacker
    {
        public Block[] Blocks { get; private set; }
        public Fit root;
        
        public GrowingPacker(Img[] imgs)
        {
            Blocks = new Block[imgs.Length];
            for (int i = 0; i < imgs.Length; i++)
            {
                Blocks[i] = new Block(imgs[i]);
            }
        }

        public void fit()
        {
            int n, len = Blocks.Length;
            Fit node;
            int w = len > 0 ? Blocks[0].Width : 0;
            int h = len > 0 ? Blocks[0].Height : 0;

            root = new Fit(0, 0, w, h);
            for (n = 0; n < len; n++)
            {
                node = findNode(root, Blocks[n].Width, Blocks[n].Height);
                if (node != null)
                    Blocks[n].FitImg = splitNode(node, Blocks[n].Width, Blocks[n].Height);
                else 
                    Blocks[n].FitImg = growNode(Blocks[n].Width, Blocks[n].Height);
            }
        }

        Fit findNode(Fit rootN, int w, int h)
        {
            if (rootN.Used)
            {
                Fit node = findNode(rootN.Right, w, h);
                return (node != null) ? node : findNode(rootN.Down, w, h);
            }
            else if ((w <= rootN.Width) && (h <= rootN.Height))
                return rootN;
            else
                return null;
        }

        Fit splitNode(Fit node, int w, int h)
        {
            node.Used = true;
            node.Down = new Fit(node.X, node.Y + h, node.Width, node.Height - h);
            node.Right = new Fit(node.X + w, node.Y, node.Width - w, h);
            return node;
        }

        Fit growNode(int w, int h)
        {
            bool canGrowDown = (w <= root.Width);
            bool canGrowRight = (h <= root.Height);

            bool shouldGrowRight = canGrowRight && (root.Height >= (root.Width + w)); // attempt to keep square-ish by growing right when height is much greater than width
            bool shouldGrowDown = canGrowDown && (root.Width >= (root.Height + h)); // attempt to keep square-ish by growing down  when width  is much greater than height

            if (shouldGrowRight)
                return growRight(w, h);
            else if (shouldGrowDown)
                return growDown(w, h);
            else if (canGrowRight)
                return growRight(w, h);
            else if (canGrowDown)
                return growDown(w, h);
            else
                return null;
        }

        Fit growRight (int w, int h)
        {
            root = new Fit(0, 0, root.Width + w, root.Height)
            {
                Used = true,
                Down = root,
                Right = new Fit(root.Width, 0,  w, root.Height)
            };
            Fit node = this.findNode(root, w, h);
            if (node != null )
                return splitNode(node, w, h);
            else
                return null;
        }

        Fit growDown (int w, int h)
        {
            root = new Fit(0, 0, root.Width, root.Height + h) {
                Used = true,
                Down = new Fit(0, root.Height, root.Width, h),
                Right = this.root
            };
            Fit node = this.findNode(this.root, w, h);
            if (node != null)
                return this.splitNode(node, w, h);
            else
                return null;
        }
    }
}
