using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using St = ChangeImgInHtml.Properties.Settings;

namespace ChangeImgInHtml
{
    public partial class Form1 : Form
    {
        ImgChange imgChange;
        BindingSource bs;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPathDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.ShowDialog();
            if (!string.IsNullOrEmpty(fd.SelectedPath))
                this.pathDirectory.Text = fd.SelectedPath;
            bs = new BindingSource();
        }

        private void btnPathFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            if (!string.IsNullOrEmpty(fileDialog.FileName))
                this.pathFile.Text = fileDialog.FileName;
        }

        private void bетReplaceImgToDiv_Click(object sender, EventArgs e)
        {
            if (!validChangeForImg()) return;
            this.listChanges.Text += "ЗАМЕНА ТЕГОВ img НА div\r\n";
            createImgChange();
            imgChange.ChangeHtml();
            this.listChanges.Text += imgChange.LogList;
        }
        private bool validChangeForImg()
        {            
            errPthDirectory.Visible = string.IsNullOrEmpty(pathDirectory.Text);
            errPathFile.Visible = string.IsNullOrEmpty(pathFile.Text);
            return !string.IsNullOrEmpty(pathDirectory.Text) && !string.IsNullOrEmpty(pathFile.Text);
        }

        private void bетReplaceImgToDivWithA_Click(object sender, EventArgs e)
        {
            if (!validChangeForImg()) return;
            this.listChanges.Text += "ЗАМЕНА ТЕГОВ img НА div С ВСПЛЫВАЮЩИМИ ПОДСКАЗКАМИ\r\n";
            createImgChange();
            imgChange.ChangeHtml(true);
            this.listChanges.Text += imgChange.LogList;
        }

        private void btnImgFiles_Click(object sender, EventArgs e)
        {
            this.listChanges.Text += "УДАЛЕНИЕ СОВПАДАЮЩИХ ФАЙЛОВ png\r\n";
            createImgChange();
            imgChange.DeleteImg();
            listChanges.Text += imgChange.LogList;
        }

        private void createImgChange()
        {
            if (imgChange == null)
                imgChange = new ImgChange(this.pathDirectory.Text, this.pathFile.Text, this.textBoxStyle.Text, this.textBox1.Text);
        }

        private void btnCreateSprite_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty( tbPngPath.Text) )
            {
                errPngPath.Visible = true;
                return;
            }
            else
                errPngPath.Visible = false;
            listChanges.Text += MyFunctions.CreateSprites(this.tbPngPath.Text);
            pathFile.Text = this.tbPngPath.Text + "\\" + St.Default.NameSpriteCSSFile + ".css";
        }

        private void btnPngPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.ShowDialog();
            if (!string.IsNullOrEmpty(fd.SelectedPath))
                this.tbPngPath.Text = fd.SelectedPath;
            
        }


        private void btnSettings_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            formSettings.ShowDialog();
        }
    }
}
