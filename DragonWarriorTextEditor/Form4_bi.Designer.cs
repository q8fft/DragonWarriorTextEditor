namespace DragonWarriorTextEditor {
    partial class Form4_bi {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4_bi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxBI4 = new System.Windows.Forms.TextBox();
            this.textBoxBI3 = new System.Windows.Forms.TextBox();
            this.textBoxBI2 = new System.Windows.Forms.TextBox();
            this.textBoxBI1 = new System.Windows.Forms.TextBox();
            this.buttonUpdateText = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxBI4);
            this.groupBox1.Controls.Add(this.textBoxBI3);
            this.groupBox1.Controls.Add(this.textBoxBI2);
            this.groupBox1.Controls.Add(this.textBoxBI1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Beginning Intro";
            // 
            // textBoxBI4
            // 
            this.textBoxBI4.Location = new System.Drawing.Point(196, 125);
            this.textBoxBI4.Multiline = true;
            this.textBoxBI4.Name = "textBoxBI4";
            this.textBoxBI4.Size = new System.Drawing.Size(184, 100);
            this.textBoxBI4.TabIndex = 3;
            // 
            // textBoxBI3
            // 
            this.textBoxBI3.Location = new System.Drawing.Point(6, 125);
            this.textBoxBI3.Multiline = true;
            this.textBoxBI3.Name = "textBoxBI3";
            this.textBoxBI3.Size = new System.Drawing.Size(184, 100);
            this.textBoxBI3.TabIndex = 2;
            // 
            // textBoxBI2
            // 
            this.textBoxBI2.Location = new System.Drawing.Point(196, 19);
            this.textBoxBI2.Multiline = true;
            this.textBoxBI2.Name = "textBoxBI2";
            this.textBoxBI2.Size = new System.Drawing.Size(184, 100);
            this.textBoxBI2.TabIndex = 1;
            // 
            // textBoxBI1
            // 
            this.textBoxBI1.Location = new System.Drawing.Point(6, 19);
            this.textBoxBI1.Multiline = true;
            this.textBoxBI1.Name = "textBoxBI1";
            this.textBoxBI1.Size = new System.Drawing.Size(184, 100);
            this.textBoxBI1.TabIndex = 0;
            // 
            // buttonUpdateText
            // 
            this.buttonUpdateText.Location = new System.Drawing.Point(536, 356);
            this.buttonUpdateText.Name = "buttonUpdateText";
            this.buttonUpdateText.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateText.TabIndex = 1;
            this.buttonUpdateText.Text = "&Update Text";
            this.buttonUpdateText.UseVisualStyleBackColor = true;
            this.buttonUpdateText.Click += new System.EventHandler(this.buttonUpdateText_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4_bi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 391);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonUpdateText);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form4_bi";
            this.Text = "MegaMan III Text Editor";
            this.Load += new System.EventHandler(this.Form4_bi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxBI4;
        private System.Windows.Forms.TextBox textBoxBI3;
        private System.Windows.Forms.TextBox textBoxBI2;
        private System.Windows.Forms.TextBox textBoxBI1;
        private System.Windows.Forms.Button buttonUpdateText;
        private System.Windows.Forms.Button button1;
    }
}