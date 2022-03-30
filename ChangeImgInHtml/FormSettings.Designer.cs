
namespace ChangeImgInHtml
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbPrefixForSinglSprite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrfixPathSpitePng = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNameSpriteCSSFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNameSinglePngSprite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSizeSprite = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbFixWidth = new System.Windows.Forms.Label();
            this.tbFixWidth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbPrefixForSinglSprite
            // 
            this.tbPrefixForSinglSprite.Location = new System.Drawing.Point(246, 35);
            this.tbPrefixForSinglSprite.Name = "tbPrefixForSinglSprite";
            this.tbPrefixForSinglSprite.Size = new System.Drawing.Size(362, 27);
            this.tbPrefixForSinglSprite.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.MaximumSize = new System.Drawing.Size(250, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Префикс класса для единственного спрайта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.MaximumSize = new System.Drawing.Size(250, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Путь для ссылки на спрайт в css";
            // 
            // tbPrfixPathSpitePng
            // 
            this.tbPrfixPathSpitePng.Location = new System.Drawing.Point(246, 79);
            this.tbPrfixPathSpitePng.Name = "tbPrfixPathSpitePng";
            this.tbPrfixPathSpitePng.Size = new System.Drawing.Size(362, 27);
            this.tbPrfixPathSpitePng.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.MaximumSize = new System.Drawing.Size(250, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Имя для файла css";
            // 
            // tbNameSpriteCSSFile
            // 
            this.tbNameSpriteCSSFile.Location = new System.Drawing.Point(246, 123);
            this.tbNameSpriteCSSFile.Name = "tbNameSpriteCSSFile";
            this.tbNameSpriteCSSFile.Size = new System.Drawing.Size(362, 27);
            this.tbNameSpriteCSSFile.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 162);
            this.label5.MaximumSize = new System.Drawing.Size(250, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 40);
            this.label5.TabIndex = 9;
            this.label5.Text = "Имя для файла png (если он один)";
            // 
            // tbNameSinglePngSprite
            // 
            this.tbNameSinglePngSprite.Location = new System.Drawing.Point(246, 167);
            this.tbNameSinglePngSprite.Name = "tbNameSinglePngSprite";
            this.tbNameSinglePngSprite.Size = new System.Drawing.Size(362, 27);
            this.tbNameSinglePngSprite.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 220);
            this.label6.MaximumSize = new System.Drawing.Size(250, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Способ компановки спрайта";
            // 
            // cmbSizeSprite
            // 
            this.cmbSizeSprite.FormattingEnabled = true;
            this.cmbSizeSprite.Items.AddRange(new object[] {
            "По убыванию с фиксированной шириной",
            "Компактный с автоматически вычисляемыми размерами"});
            this.cmbSizeSprite.Location = new System.Drawing.Point(246, 211);
            this.cmbSizeSprite.Name = "cmbSizeSprite";
            this.cmbSizeSprite.Size = new System.Drawing.Size(362, 28);
            this.cmbSizeSprite.TabIndex = 12;
            this.cmbSizeSprite.SelectedIndexChanged += new System.EventHandler(this.cmbSizeSprite_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(512, 309);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbFixWidth
            // 
            this.lbFixWidth.AutoSize = true;
            this.lbFixWidth.Location = new System.Drawing.Point(12, 258);
            this.lbFixWidth.MaximumSize = new System.Drawing.Size(250, 0);
            this.lbFixWidth.Name = "lbFixWidth";
            this.lbFixWidth.Size = new System.Drawing.Size(67, 20);
            this.lbFixWidth.TabIndex = 16;
            this.lbFixWidth.Text = "Ширина";
            this.lbFixWidth.Visible = false;
            // 
            // tbFixWidth
            // 
            this.tbFixWidth.Location = new System.Drawing.Point(246, 256);
            this.tbFixWidth.Name = "tbFixWidth";
            this.tbFixWidth.Size = new System.Drawing.Size(362, 27);
            this.tbFixWidth.TabIndex = 15;
            this.tbFixWidth.Visible = false;
            this.tbFixWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFixWidth_KeyPress);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 364);
            this.Controls.Add(this.lbFixWidth);
            this.Controls.Add(this.tbFixWidth);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbSizeSprite);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNameSinglePngSprite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNameSpriteCSSFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPrfixPathSpitePng);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPrefixForSinglSprite);
            this.Name = "FormSettings";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPrefixForSinglSprite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrfixPathSpitePng;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNameSpriteCSSFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNameSinglePngSprite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSizeSprite;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbFixWidth;
        private System.Windows.Forms.TextBox tbFixWidth;
    }
}