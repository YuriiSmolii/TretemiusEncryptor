
namespace CaesarEncryptor
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
            this.OriginalText = new System.Windows.Forms.RichTextBox();
            this.DecryptedText = new System.Windows.Forms.RichTextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.bruteForceButton = new System.Windows.Forms.Button();
            this.inputBoxLable = new System.Windows.Forms.Label();
            this.resultBoxLable = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frequencyTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukrainianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.inputFrequency = new System.Windows.Forms.Button();
            this.outputFreuency = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.choseLanguageLable = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.numericUpDownKey2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKey3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKey4 = new System.Windows.Forms.NumericUpDown();
            this.textBoxGaslo = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKey2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKey3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKey4)).BeginInit();
            this.SuspendLayout();
            // 
            // OriginalText
            // 
            this.OriginalText.Location = new System.Drawing.Point(17, 70);
            this.OriginalText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OriginalText.Name = "OriginalText";
            this.OriginalText.Size = new System.Drawing.Size(487, 617);
            this.OriginalText.TabIndex = 0;
            this.OriginalText.Text = "";
            // 
            // DecryptedText
            // 
            this.DecryptedText.Location = new System.Drawing.Point(637, 70);
            this.DecryptedText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DecryptedText.Name = "DecryptedText";
            this.DecryptedText.ReadOnly = true;
            this.DecryptedText.Size = new System.Drawing.Size(487, 617);
            this.DecryptedText.TabIndex = 1;
            this.DecryptedText.Text = "";
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(514, 553);
            this.encryptButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(107, 38);
            this.encryptButton.TabIndex = 4;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(514, 601);
            this.decryptButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(107, 38);
            this.decryptButton.TabIndex = 5;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // bruteForceButton
            // 
            this.bruteForceButton.Location = new System.Drawing.Point(514, 649);
            this.bruteForceButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bruteForceButton.Name = "bruteForceButton";
            this.bruteForceButton.Size = new System.Drawing.Size(107, 38);
            this.bruteForceButton.TabIndex = 6;
            this.bruteForceButton.Text = "Attack";
            this.bruteForceButton.UseVisualStyleBackColor = true;
            this.bruteForceButton.Click += new System.EventHandler(this.bruteForceButton_Click);
            // 
            // inputBoxLable
            // 
            this.inputBoxLable.AutoSize = true;
            this.inputBoxLable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputBoxLable.Location = new System.Drawing.Point(17, 40);
            this.inputBoxLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputBoxLable.Name = "inputBoxLable";
            this.inputBoxLable.Size = new System.Drawing.Size(224, 25);
            this.inputBoxLable.TabIndex = 10;
            this.inputBoxLable.Text = "Opened file / Input text :";
            // 
            // resultBoxLable
            // 
            this.resultBoxLable.AutoSize = true;
            this.resultBoxLable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultBoxLable.Location = new System.Drawing.Point(637, 40);
            this.resultBoxLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultBoxLable.Name = "resultBoxLable";
            this.resultBoxLable.Size = new System.Drawing.Size(161, 25);
            this.resultBoxLable.TabIndex = 11;
            this.resultBoxLable.Text = "Operation result :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.pictureToolStripMenuItem,
            this.frequencyTablesToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1143, 35);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.printToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // pictureToolStripMenuItem
            // 
            this.pictureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptToolStripMenuItem,
            this.decryptToolStripMenuItem});
            this.pictureToolStripMenuItem.Name = "pictureToolStripMenuItem";
            this.pictureToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.pictureToolStripMenuItem.Text = "Picture";
            // 
            // encryptToolStripMenuItem
            // 
            this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            this.encryptToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.encryptToolStripMenuItem.Text = "Encrypt";
            this.encryptToolStripMenuItem.Click += new System.EventHandler(this.encryptToolStripMenuItem_Click);
            // 
            // decryptToolStripMenuItem
            // 
            this.decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
            this.decryptToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.decryptToolStripMenuItem.Text = "Decrypt";
            this.decryptToolStripMenuItem.Click += new System.EventHandler(this.decryptToolStripMenuItem_Click);
            // 
            // frequencyTablesToolStripMenuItem
            // 
            this.frequencyTablesToolStripMenuItem.Checked = true;
            this.frequencyTablesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.frequencyTablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ukrainianToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.frequencyTablesToolStripMenuItem.Name = "frequencyTablesToolStripMenuItem";
            this.frequencyTablesToolStripMenuItem.Size = new System.Drawing.Size(162, 29);
            this.frequencyTablesToolStripMenuItem.Text = "Frequency Tables";
            // 
            // ukrainianToolStripMenuItem
            // 
            this.ukrainianToolStripMenuItem.Name = "ukrainianToolStripMenuItem";
            this.ukrainianToolStripMenuItem.Size = new System.Drawing.Size(187, 34);
            this.ukrainianToolStripMenuItem.Text = "Ukrainian";
            this.ukrainianToolStripMenuItem.Click += new System.EventHandler(this.ukrainianToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(187, 34);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(78, 29);
            this.toolStripMenuItem1.Text = "About";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(183, 34);
            this.toolStripMenuItem2.Text = "Program";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // inputFrequency
            // 
            this.inputFrequency.Location = new System.Drawing.Point(17, 698);
            this.inputFrequency.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputFrequency.Name = "inputFrequency";
            this.inputFrequency.Size = new System.Drawing.Size(149, 38);
            this.inputFrequency.TabIndex = 13;
            this.inputFrequency.Text = "Frequency table";
            this.inputFrequency.UseVisualStyleBackColor = true;
            this.inputFrequency.Click += new System.EventHandler(this.inputFrequency_Click);
            // 
            // outputFreuency
            // 
            this.outputFreuency.Location = new System.Drawing.Point(975, 698);
            this.outputFreuency.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outputFreuency.Name = "outputFreuency";
            this.outputFreuency.Size = new System.Drawing.Size(149, 38);
            this.outputFreuency.TabIndex = 14;
            this.outputFreuency.Text = "Frequency table";
            this.outputFreuency.UseVisualStyleBackColor = true;
            this.outputFreuency.Click += new System.EventHandler(this.outputFreuency_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ukrainian",
            "English"});
            this.comboBox1.Location = new System.Drawing.Point(514, 125);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(107, 33);
            this.comboBox1.TabIndex = 16;
            // 
            // choseLanguageLable
            // 
            this.choseLanguageLable.AutoSize = true;
            this.choseLanguageLable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.choseLanguageLable.Location = new System.Drawing.Point(514, 70);
            this.choseLanguageLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.choseLanguageLable.Name = "choseLanguageLable";
            this.choseLanguageLable.Size = new System.Drawing.Size(96, 50);
            this.choseLanguageLable.TabIndex = 17;
            this.choseLanguageLable.Text = "Select a \r\nlanguage:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(514, 210);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 29);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "2d";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(514, 245);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 29);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "3d";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(514, 450);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(90, 29);
            this.radioButton3.TabIndex = 21;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "phrase";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // numericUpDownKey2
            // 
            this.numericUpDownKey2.Location = new System.Drawing.Point(514, 280);
            this.numericUpDownKey2.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDownKey2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKey2.Name = "numericUpDownKey2";
            this.numericUpDownKey2.Size = new System.Drawing.Size(107, 31);
            this.numericUpDownKey2.TabIndex = 22;
            this.numericUpDownKey2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownKey3
            // 
            this.numericUpDownKey3.Location = new System.Drawing.Point(514, 326);
            this.numericUpDownKey3.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDownKey3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKey3.Name = "numericUpDownKey3";
            this.numericUpDownKey3.Size = new System.Drawing.Size(107, 31);
            this.numericUpDownKey3.TabIndex = 23;
            this.numericUpDownKey3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownKey4
            // 
            this.numericUpDownKey4.Location = new System.Drawing.Point(514, 372);
            this.numericUpDownKey4.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDownKey4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKey4.Name = "numericUpDownKey4";
            this.numericUpDownKey4.Size = new System.Drawing.Size(107, 31);
            this.numericUpDownKey4.TabIndex = 24;
            this.numericUpDownKey4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxGaslo
            // 
            this.textBoxGaslo.Location = new System.Drawing.Point(514, 485);
            this.textBoxGaslo.Name = "textBoxGaslo";
            this.textBoxGaslo.Size = new System.Drawing.Size(107, 31);
            this.textBoxGaslo.TabIndex = 25;
            this.textBoxGaslo.TextChanged += new System.EventHandler(this.textBoxGaslo_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.textBoxGaslo);
            this.Controls.Add(this.numericUpDownKey4);
            this.Controls.Add(this.numericUpDownKey3);
            this.Controls.Add(this.numericUpDownKey2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.choseLanguageLable);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.outputFreuency);
            this.Controls.Add(this.inputFrequency);
            this.Controls.Add(this.resultBoxLable);
            this.Controls.Add(this.inputBoxLable);
            this.Controls.Add(this.bruteForceButton);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.DecryptedText);
            this.Controls.Add(this.OriginalText);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TretemiusEncryptor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKey2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKey3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKey4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox OriginalText;
        private System.Windows.Forms.RichTextBox DecryptedText;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button bruteForceButton;
        private System.Windows.Forms.Label inputBoxLable;
        private System.Windows.Forms.Label resultBoxLable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frequencyTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ukrainianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button inputFrequency;
        private System.Windows.Forms.Button outputFreuency;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label choseLanguageLable;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem pictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.NumericUpDown numericUpDownKey2;
        private System.Windows.Forms.NumericUpDown numericUpDownKey3;
        private System.Windows.Forms.NumericUpDown numericUpDownKey4;
        private System.Windows.Forms.TextBox textBoxGaslo;
    }
}

