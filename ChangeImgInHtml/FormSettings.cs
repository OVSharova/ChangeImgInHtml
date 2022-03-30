using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using St = ChangeImgInHtml.Properties.Settings;

namespace ChangeImgInHtml
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            tbPrefixForSinglSprite.Text = St.Default.PrefixForSinglSprite;
            tbNameSinglePngSprite.Text = St.Default.NameSinglePngSprite;
            tbPrfixPathSpitePng.Text = St.Default.PrfixPathSpitePng;
            tbNameSpriteCSSFile.Text = St.Default.NameSpriteCSSFile;
            tbFixWidth.Text = St.Default.FixWidth.ToString();
            cmbSizeSprite.SelectedIndex = St.Default.sizeSprite;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int intPointPng = tbNameSinglePngSprite.Text.IndexOf('.'), 
                    intPointCSS = tbNameSpriteCSSFile.Text.IndexOf('.');

                St.Default.PrefixForSinglSprite = tbPrefixForSinglSprite.Text;
                St.Default.NameSinglePngSprite = (intPointPng < 0) ? tbNameSinglePngSprite.Text : tbNameSinglePngSprite.Text.Substring(intPointPng);
                St.Default.PrfixPathSpitePng = tbPrfixPathSpitePng.Text;
                St.Default.NameSpriteCSSFile = (intPointCSS < 0) ? tbNameSpriteCSSFile.Text : tbNameSpriteCSSFile.Text.Substring(intPointCSS);
                St.Default.FixWidth = Convert.ToInt32(tbFixWidth.Text);
                St.Default.sizeSprite = cmbSizeSprite.SelectedIndex;
                Close();
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbSizeSprite_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFixWidth.Visible = (cmbSizeSprite.SelectedIndex != (int)SizeSprite.AutomaticSize);
            lbFixWidth.Visible = tbFixWidth.Visible;
        }

        private void tbFixWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
