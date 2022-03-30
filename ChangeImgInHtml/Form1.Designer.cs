
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
            this.bетReplaceImgToDiv = new System.Windows.Forms.Button();
            this.btnImgFiles = new System.Windows.Forms.Button();
            this.bетReplaceImgToDivWithA = new System.Windows.Forms.Button();
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
            this.btnCreateSprite = new System.Windows.Forms.Button();
            this.listChanges = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bетReplaceImgToDiv
            // 
            this.bетReplaceImgToDiv.Location = new System.Drawing.Point(12, 282);
            this.bетReplaceImgToDiv.Name = "bетReplaceImgToDiv";
            this.bетReplaceImgToDiv.Size = new System.Drawing.Size(223, 60);
            this.bетReplaceImgToDiv.TabIndex = 0;
            this.bетReplaceImgToDiv.Text = "Замена img  на div";
            this.bетReplaceImgToDiv.UseVisualStyleBackColor = true;
            this.bетReplaceImgToDiv.Click += new System.EventHandler(this.bетReplaceImgToDiv_Click);
            // 
            // btnImgFiles
            // 
            this.btnImgFiles.Location = new System.Drawing.Point(12, 404);
            this.btnImgFiles.Name = "btnImgFiles";
            this.btnImgFiles.Size = new System.Drawing.Size(223, 60);
            this.btnImgFiles.TabIndex = 2;
            this.btnImgFiles.Text = "удаление совпадающих файлов";
            this.btnImgFiles.UseVisualStyleBackColor = true;
            this.btnImgFiles.Click += new System.EventHandler(this.btnImgFiles_Click);
            // 
            // bетReplaceImgToDivWithA
            // 
            this.bетReplaceImgToDivWithA.Location = new System.Drawing.Point(12, 343);
            this.bетReplaceImgToDivWithA.Name = "bетReplaceImgToDivWithA";
            this.bетReplaceImgToDivWithA.Size = new System.Drawing.Size(223, 60);
            this.bетReplaceImgToDivWithA.TabIndex = 3;
            this.bетReplaceImgToDivWithA.Text = "Замена img  на div c подсказкой";
            this.bетReplaceImgToDivWithA.UseVisualStyleBackColor = true;
            this.bетReplaceImgToDivWithA.Click += new System.EventHandler(this.bетReplaceImgToDivWithA_Click);
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
            this.btnPngPath.Location = new System.Drawing.Point(680, 42);
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
            // btnCreateSprite
            // 
            this.btnCreateSprite.Location = new System.Drawing.Point(12, 465);
            this.btnCreateSprite.Name = "btnCreateSprite";
            this.btnCreateSprite.Size = new System.Drawing.Size(223, 60);
            this.btnCreateSprite.TabIndex = 20;
            this.btnCreateSprite.Text = "Создать спрайт";
            this.btnCreateSprite.UseVisualStyleBackColor = true;
            this.btnCreateSprite.Click += new System.EventHandler(this.btnCreateSprite_Click);
            // 
            // listChanges
            // 
            this.listChanges.Location = new System.Drawing.Point(256, 282);
            this.listChanges.Name = "listChanges";
            this.listChanges.ReadOnly = true;
            this.listChanges.Size = new System.Drawing.Size(487, 243);
            this.listChanges.TabIndex = 23;
            this.listChanges.Text = "";
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
            this.Controls.Add(this.btnCreateSprite);
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
            this.Controls.Add(this.bетReplaceImgToDivWithA);
            this.Controls.Add(this.btnImgFiles);
            this.Controls.Add(this.bетReplaceImgToDiv);
            this.Name = "Form1";
            this.Text = "Работа с изображениями";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bетReplaceImgToDiv;
        private System.Windows.Forms.Button btnImgFiles;
        private System.Windows.Forms.Button bетReplaceImgToDivWithA;
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
        private System.Windows.Forms.Button btnCreateSprite;
        private System.Windows.Forms.RichTextBox listChanges;
    }
}

