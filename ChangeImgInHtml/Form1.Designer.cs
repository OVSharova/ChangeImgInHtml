
namespace ChangeImgInHtml
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pathDirectory = new System.Windows.Forms.TextBox();
            this.pathFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStyle = new System.Windows.Forms.TextBox();
            this.btnPathDirectory = new System.Windows.Forms.Button();
            this.btnPathFile = new System.Windows.Forms.Button();
            this.errPathFile = new System.Windows.Forms.Label();
            this.errPthDirectory = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbPngPath = new System.Windows.Forms.TextBox();
            this.btnPngPath = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.errPngPath = new System.Windows.Forms.Label();
            this.listChanges = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.аToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filesImgFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.filesCreateSprite = new System.Windows.Forms.ToolStripMenuItem();
            this.links = new System.Windows.Forms.ToolStripMenuItem();
            this.linksReplaceImgToDiv = new System.Windows.Forms.ToolStripMenuItem();
            this.linksReplaceImgToDivWithA = new System.Windows.Forms.ToolStripMenuItem();
            this.linksReplacementSrc = new System.Windows.Forms.ToolStripMenuItem();
            this.filesDeliteGrneralFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pathDirectory
            // 
            this.pathDirectory.BackColor = System.Drawing.SystemColors.Window;
            this.pathDirectory.Location = new System.Drawing.Point(253, 93);
            this.pathDirectory.Name = "pathDirectory";
            this.pathDirectory.ReadOnly = true;
            this.pathDirectory.Size = new System.Drawing.Size(453, 27);
            this.pathDirectory.TabIndex = 4;
            // 
            // pathFile
            // 
            this.pathFile.BackColor = System.Drawing.SystemColors.Window;
            this.pathFile.Location = new System.Drawing.Point(253, 143);
            this.pathFile.Name = "pathFile";
            this.pathFile.ReadOnly = true;
            this.pathFile.Size = new System.Drawing.Size(453, 27);
            this.pathFile.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Файл стиля спрайта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Редактируемая папка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.MaximumSize = new System.Drawing.Size(200, 0);
            this.label3.MinimumSize = new System.Drawing.Size(200, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Добавка к адресу css файла";
            // 
            // textBoxStyle
            // 
            this.textBoxStyle.Location = new System.Drawing.Point(253, 187);
            this.textBoxStyle.Name = "textBoxStyle";
            this.textBoxStyle.Size = new System.Drawing.Size(490, 27);
            this.textBoxStyle.TabIndex = 8;
            this.textBoxStyle.Text = "../../images/";
            // 
            // btnPathDirectory
            // 
            this.btnPathDirectory.Location = new System.Drawing.Point(705, 92);
            this.btnPathDirectory.Name = "btnPathDirectory";
            this.btnPathDirectory.Size = new System.Drawing.Size(38, 29);
            this.btnPathDirectory.TabIndex = 10;
            this.btnPathDirectory.Text = "...";
            this.btnPathDirectory.UseVisualStyleBackColor = true;
            this.btnPathDirectory.Click += new System.EventHandler(this.btnPathDirectory_Click);
            // 
            // btnPathFile
            // 
            this.btnPathFile.Location = new System.Drawing.Point(705, 142);
            this.btnPathFile.Name = "btnPathFile";
            this.btnPathFile.Size = new System.Drawing.Size(38, 29);
            this.btnPathFile.TabIndex = 11;
            this.btnPathFile.Text = "...";
            this.btnPathFile.UseVisualStyleBackColor = true;
            this.btnPathFile.Click += new System.EventHandler(this.btnPathFile_Click);
            // 
            // errPathFile
            // 
            this.errPathFile.AutoSize = true;
            this.errPathFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errPathFile.ForeColor = System.Drawing.Color.Red;
            this.errPathFile.Location = new System.Drawing.Point(256, 121);
            this.errPathFile.Name = "errPathFile";
            this.errPathFile.Size = new System.Drawing.Size(227, 20);
            this.errPathFile.TabIndex = 12;
            this.errPathFile.Text = "Необходимо указать файл css";
            this.errPathFile.Visible = false;
            // 
            // errPthDirectory
            // 
            this.errPthDirectory.AutoSize = true;
            this.errPthDirectory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errPthDirectory.ForeColor = System.Drawing.Color.Red;
            this.errPthDirectory.Location = new System.Drawing.Point(235, 70);
            this.errPthDirectory.Name = "errPthDirectory";
            this.errPthDirectory.Size = new System.Drawing.Size(517, 20);
            this.errPthDirectory.TabIndex = 13;
            this.errPthDirectory.Text = "Необходимо указать папку, содержащую редактируемые htm файлы";
            this.errPthDirectory.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 224);
            this.label4.MaximumSize = new System.Drawing.Size(200, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 40);
            this.label4.TabIndex = 16;
            this.label4.Text = "Адрес уже прикркпленного файла";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(253, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(490, 27);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "meta name";
            // 
            // tbPngPath
            // 
            this.tbPngPath.BackColor = System.Drawing.SystemColors.Window;
            this.tbPngPath.Location = new System.Drawing.Point(253, 43);
            this.tbPngPath.Name = "tbPngPath";
            this.tbPngPath.ReadOnly = true;
            this.tbPngPath.Size = new System.Drawing.Size(427, 27);
            this.tbPngPath.TabIndex = 17;
            // 
            // btnPngPath
            // 
            this.btnPngPath.Location = new System.Drawing.Point(679, 42);
            this.btnPngPath.Name = "btnPngPath";
            this.btnPngPath.Size = new System.Drawing.Size(38, 29);
            this.btnPngPath.TabIndex = 19;
            this.btnPngPath.Text = "...";
            this.btnPngPath.UseVisualStyleBackColor = true;
            this.btnPngPath.Click += new System.EventHandler(this.btnPngPath_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Папка с изображениями ";
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.BackgroundImage")));
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.Location = new System.Drawing.Point(715, 42);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(28, 29);
            this.btnSettings.TabIndex = 21;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // errPngPath
            // 
            this.errPngPath.AutoSize = true;
            this.errPngPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errPngPath.ForeColor = System.Drawing.Color.Red;
            this.errPngPath.Location = new System.Drawing.Point(253, 20);
            this.errPngPath.Name = "errPngPath";
            this.errPngPath.Size = new System.Drawing.Size(341, 20);
            this.errPngPath.TabIndex = 22;
            this.errPngPath.Text = "Необходимо указать папку с изображениями";
            this.errPngPath.Visible = false;
            // 
            // listChanges
            // 
            this.listChanges.Location = new System.Drawing.Point(12, 267);
            this.listChanges.Name = "listChanges";
            this.listChanges.ReadOnly = true;
            this.listChanges.Size = new System.Drawing.Size(731, 266);
            this.listChanges.TabIndex = 23;
            this.listChanges.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.аToolStripMenuItem,
            this.links});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 28);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // аToolStripMenuItem
            // 
            this.аToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesImgFiles,
            this.filesCreateSprite,
            this.filesDeliteGrneralFiles});
            this.аToolStripMenuItem.Name = "аToolStripMenuItem";
            this.аToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.аToolStripMenuItem.Text = "Files";
            // 
            // filesImgFiles
            // 
            this.filesImgFiles.Name = "filesImgFiles";
            this.filesImgFiles.Size = new System.Drawing.Size(316, 26);
            this.filesImgFiles.Text = "Удаление совпадающих файлов";
            this.filesImgFiles.Click += new System.EventHandler(this.btnImgFiles_Click);
            // 
            // filesCreateSprite
            // 
            this.filesCreateSprite.Name = "filesCreateSprite";
            this.filesCreateSprite.Size = new System.Drawing.Size(316, 26);
            this.filesCreateSprite.Text = "Создать спрайт";
            this.filesCreateSprite.Click += new System.EventHandler(this.btnCreateSprite_Click);
            // 
            // links
            // 
            this.links.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linksReplaceImgToDiv,
            this.linksReplaceImgToDivWithA,
            this.linksReplacementSrc});
            this.links.Name = "links";
            this.links.Size = new System.Drawing.Size(55, 24);
            this.links.Text = "Links";
            // 
            // linksReplaceImgToDiv
            // 
            this.linksReplaceImgToDiv.Name = "linksReplaceImgToDiv";
            this.linksReplaceImgToDiv.Size = new System.Drawing.Size(356, 26);
            this.linksReplaceImgToDiv.Text = "Замена img  на div";
            this.linksReplaceImgToDiv.Click += new System.EventHandler(this.btnReplaceImgToDiv_Click);
            // 
            // linksReplaceImgToDivWithA
            // 
            this.linksReplaceImgToDivWithA.Name = "linksReplaceImgToDivWithA";
            this.linksReplaceImgToDivWithA.Size = new System.Drawing.Size(356, 26);
            this.linksReplaceImgToDivWithA.Text = "Замена img  на div c подсказкой";
            this.linksReplaceImgToDivWithA.Click += new System.EventHandler(this.btnReplaceImgToDivWithA_Click);
            // 
            // linksReplacementSrc
            // 
            this.linksReplacementSrc.Name = "linksReplacementSrc";
            this.linksReplacementSrc.Size = new System.Drawing.Size(356, 26);
            this.linksReplacementSrc.Text = "Замена адресов общих изображений";
            this.linksReplacementSrc.Click += new System.EventHandler(this.linksReplacementSrc_Click);
            // 
            // filesDeliteGrneralFiles
            // 
            this.filesDeliteGrneralFiles.Name = "filesDeliteGrneralFiles";
            this.filesDeliteGrneralFiles.Size = new System.Drawing.Size(316, 26);
            this.filesDeliteGrneralFiles.Text = "Удаление общих файлов";
            this.filesDeliteGrneralFiles.Click += new System.EventHandler(this.filesDeliteGrneralFiles_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 545);
            this.Controls.Add(this.listChanges);
            this.Controls.Add(this.errPngPath);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.tbPngPath);
            this.Controls.Add(this.btnPngPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pathDirectory);
            this.Controls.Add(this.pathFile);
            this.Controls.Add(this.errPthDirectory);
            this.Controls.Add(this.errPathFile);
            this.Controls.Add(this.btnPathFile);
            this.Controls.Add(this.btnPathDirectory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxStyle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Работа с изображениями";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox pathDirectory;
        private System.Windows.Forms.TextBox pathFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStyle;
        private System.Windows.Forms.Button btnPathDirectory;
        private System.Windows.Forms.Button btnPathFile;
        private System.Windows.Forms.Label errPathFile;
        private System.Windows.Forms.Label errPthDirectory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbPngPath;
        private System.Windows.Forms.Button btnPngPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label errPngPath;
        private System.Windows.Forms.RichTextBox listChanges;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem аToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem links;
        private System.Windows.Forms.ToolStripMenuItem linksReplaceImgToDiv;
        private System.Windows.Forms.ToolStripMenuItem filesImgFiles;
        private System.Windows.Forms.ToolStripMenuItem filesCreateSprite;
        private System.Windows.Forms.ToolStripMenuItem linksReplaceImgToDivWithA;
        private System.Windows.Forms.ToolStripMenuItem linksReplacementSrc;
        private System.Windows.Forms.ToolStripMenuItem filesDeliteGrneralFiles;
    }
}

