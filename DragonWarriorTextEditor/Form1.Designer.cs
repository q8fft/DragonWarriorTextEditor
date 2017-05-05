namespace DragonWarriorTextEditor {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonUpdateText = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordGameoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weaponNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drLightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robotListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mM3RobotsCreatorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelFilename = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonOpenRom = new System.Windows.Forms.Button();
            this.textBoxFilename = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUpdateText
            // 
            this.buttonUpdateText.Location = new System.Drawing.Point(374, 149);
            this.buttonUpdateText.Name = "buttonUpdateText";
            this.buttonUpdateText.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateText.TabIndex = 1;
            this.buttonUpdateText.Text = "&Update Text";
            this.buttonUpdateText.UseVisualStyleBackColor = true;
            this.buttonUpdateText.Click += new System.EventHandler(this.buttonUpdateText_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(462, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.openToolStripMenuItem.Text = "&Open ROM";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passwordGameoverToolStripMenuItem,
            this.weaponNamesToolStripMenuItem,
            this.drLightToolStripMenuItem,
            this.endingToolStripMenuItem,
            this.robotListToolStripMenuItem,
            this.mM3RobotsCreatorsToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // passwordGameoverToolStripMenuItem
            // 
            this.passwordGameoverToolStripMenuItem.Name = "passwordGameoverToolStripMenuItem";
            this.passwordGameoverToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.passwordGameoverToolStripMenuItem.Text = "&Spells";
            this.passwordGameoverToolStripMenuItem.Click += new System.EventHandler(this.updateTextToolStripMenuItem_Click);
            // 
            // weaponNamesToolStripMenuItem
            // 
            this.weaponNamesToolStripMenuItem.Name = "weaponNamesToolStripMenuItem";
            this.weaponNamesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.weaponNamesToolStripMenuItem.Text = "&Items";
            this.weaponNamesToolStripMenuItem.Click += new System.EventHandler(this.weaponNamesToolStripMenuItem_Click);
            // 
            // drLightToolStripMenuItem
            // 
            this.drLightToolStripMenuItem.Name = "drLightToolStripMenuItem";
            this.drLightToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.drLightToolStripMenuItem.Text = "&Menus";
            this.drLightToolStripMenuItem.Click += new System.EventHandler(this.drLightToolStripMenuItem_Click);
            // 
            // endingToolStripMenuItem
            // 
            this.endingToolStripMenuItem.Name = "endingToolStripMenuItem";
            this.endingToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.endingToolStripMenuItem.Text = "&Equipment";
            this.endingToolStripMenuItem.Click += new System.EventHandler(this.endingToolStripMenuItem_Click);
            // 
            // robotListToolStripMenuItem
            // 
            this.robotListToolStripMenuItem.Name = "robotListToolStripMenuItem";
            this.robotListToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.robotListToolStripMenuItem.Text = "&Title";
            this.robotListToolStripMenuItem.Click += new System.EventHandler(this.robotListToolStripMenuItem_Click);
            // 
            // mM3RobotsCreatorsToolStripMenuItem
            // 
            this.mM3RobotsCreatorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.text3ToolStripMenuItem,
            this.text2ToolStripMenuItem,
            this.text4ToolStripMenuItem,
            this.text5ToolStripMenuItem,
            this.text6ToolStripMenuItem,
            this.text7ToolStripMenuItem,
            this.text8ToolStripMenuItem,
            this.text9ToolStripMenuItem});
            this.mM3RobotsCreatorsToolStripMenuItem.Name = "mM3RobotsCreatorsToolStripMenuItem";
            this.mM3RobotsCreatorsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.mM3RobotsCreatorsToolStripMenuItem.Text = "&Text";
            this.mM3RobotsCreatorsToolStripMenuItem.Click += new System.EventHandler(this.mM3RobotsCreatorsToolStripMenuItem_Click);
            // 
            // text3ToolStripMenuItem
            // 
            this.text3ToolStripMenuItem.Name = "text3ToolStripMenuItem";
            this.text3ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.text3ToolStripMenuItem.Text = "text2";
            this.text3ToolStripMenuItem.Click += new System.EventHandler(this.text3ToolStripMenuItem_Click);
            // 
            // text2ToolStripMenuItem
            // 
            this.text2ToolStripMenuItem.Name = "text2ToolStripMenuItem";
            this.text2ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.text2ToolStripMenuItem.Text = "text3";
            this.text2ToolStripMenuItem.Click += new System.EventHandler(this.text2ToolStripMenuItem_Click);
            // 
            // text4ToolStripMenuItem
            // 
            this.text4ToolStripMenuItem.Name = "text4ToolStripMenuItem";
            this.text4ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.text4ToolStripMenuItem.Text = "text4";
            this.text4ToolStripMenuItem.Click += new System.EventHandler(this.text4ToolStripMenuItem_Click);
            // 
            // text5ToolStripMenuItem
            // 
            this.text5ToolStripMenuItem.Name = "text5ToolStripMenuItem";
            this.text5ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.text5ToolStripMenuItem.Text = "text5";
            this.text5ToolStripMenuItem.Click += new System.EventHandler(this.text5ToolStripMenuItem_Click);
            // 
            // text6ToolStripMenuItem
            // 
            this.text6ToolStripMenuItem.Name = "text6ToolStripMenuItem";
            this.text6ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.text6ToolStripMenuItem.Text = "text6";
            this.text6ToolStripMenuItem.Click += new System.EventHandler(this.text6ToolStripMenuItem_Click);
            // 
            // text7ToolStripMenuItem
            // 
            this.text7ToolStripMenuItem.Name = "text7ToolStripMenuItem";
            this.text7ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.text7ToolStripMenuItem.Text = "text7";
            this.text7ToolStripMenuItem.Click += new System.EventHandler(this.text7ToolStripMenuItem_Click);
            // 
            // text8ToolStripMenuItem
            // 
            this.text8ToolStripMenuItem.Name = "text8ToolStripMenuItem";
            this.text8ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.text8ToolStripMenuItem.Text = "text8";
            this.text8ToolStripMenuItem.Click += new System.EventHandler(this.text8ToolStripMenuItem_Click);
            // 
            // text9ToolStripMenuItem
            // 
            this.text9ToolStripMenuItem.Name = "text9ToolStripMenuItem";
            this.text9ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.text9ToolStripMenuItem.Text = "text9";
            this.text9ToolStripMenuItem.Click += new System.EventHandler(this.text9ToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.creditsToolStripMenuItem.Text = "&Monsters";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // labelFilename
            // 
            this.labelFilename.AutoSize = true;
            this.labelFilename.Location = new System.Drawing.Point(6, 16);
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(53, 13);
            this.labelFilename.TabIndex = 0;
            this.labelFilename.Text = "Filename:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonOpenRom);
            this.groupBox2.Controls.Add(this.textBoxFilename);
            this.groupBox2.Controls.Add(this.labelFilename);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 44);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // buttonOpenRom
            // 
            this.buttonOpenRom.Location = new System.Drawing.Point(352, 11);
            this.buttonOpenRom.Name = "buttonOpenRom";
            this.buttonOpenRom.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenRom.TabIndex = 1;
            this.buttonOpenRom.Text = "&Open ROM";
            this.buttonOpenRom.UseVisualStyleBackColor = true;
            this.buttonOpenRom.Click += new System.EventHandler(this.buttonOpenRom_Click);
            // 
            // textBoxFilename
            // 
            this.textBoxFilename.Location = new System.Drawing.Point(64, 13);
            this.textBoxFilename.Name = "textBoxFilename";
            this.textBoxFilename.ReadOnly = true;
            this.textBoxFilename.Size = new System.Drawing.Size(282, 20);
            this.textBoxFilename.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(331, 37);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ“”\'*:$.,-?!;)(<’>゜ﾟ" +
    "|шĚьёƓΣϊ~®#»ś¢";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Location = new System.Drawing.Point(13, 77);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(436, 66);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valid Characters:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 179);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonUpdateText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Dragon Quest I - Text Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordGameoverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label labelFilename;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonOpenRom;
        private System.Windows.Forms.TextBox textBoxFilename;
        private System.Windows.Forms.Button buttonUpdateText;
        private System.Windows.Forms.ToolStripMenuItem weaponNamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drLightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robotListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mM3RobotsCreatorsToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem text2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem text3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem text4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem text5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem text6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem text7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem text8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem text9ToolStripMenuItem;
    }
}

