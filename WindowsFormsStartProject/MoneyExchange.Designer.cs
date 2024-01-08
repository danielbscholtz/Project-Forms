namespace WindowsFormsStartProject
{
    partial class MoneyExchange
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupTo = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toBrl = new System.Windows.Forms.RadioButton();
            this.toGbp = new System.Windows.Forms.RadioButton();
            this.toEur = new System.Windows.Forms.RadioButton();
            this.toUsd = new System.Windows.Forms.RadioButton();
            this.toCad = new System.Windows.Forms.RadioButton();
            this.groupFrom = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fromBrl = new System.Windows.Forms.RadioButton();
            this.fromGbp = new System.Windows.Forms.RadioButton();
            this.fromEur = new System.Windows.Forms.RadioButton();
            this.fromUsd = new System.Windows.Forms.RadioButton();
            this.fromCad = new System.Windows.Forms.RadioButton();
            this.groupTo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.groupFrom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 266);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(238, 266);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(153, 22);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "&Read File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(292, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 31);
            this.button3.TabIndex = 6;
            this.button3.Text = "&Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupTo
            // 
            this.groupTo.Controls.Add(this.pictureBox6);
            this.groupTo.Controls.Add(this.pictureBox7);
            this.groupTo.Controls.Add(this.pictureBox8);
            this.groupTo.Controls.Add(this.pictureBox9);
            this.groupTo.Controls.Add(this.pictureBox10);
            this.groupTo.Controls.Add(this.label2);
            this.groupTo.Controls.Add(this.toBrl);
            this.groupTo.Controls.Add(this.toGbp);
            this.groupTo.Controls.Add(this.toEur);
            this.groupTo.Controls.Add(this.toUsd);
            this.groupTo.Controls.Add(this.toCad);
            this.groupTo.Location = new System.Drawing.Point(238, 44);
            this.groupTo.Name = "groupTo";
            this.groupTo.Size = new System.Drawing.Size(153, 216);
            this.groupTo.TabIndex = 7;
            this.groupTo.TabStop = false;
            this.groupTo.Text = "TO";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::WindowsFormsStartProject.Properties.Resources.brl;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(79, 183);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(44, 27);
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::WindowsFormsStartProject.Properties.Resources.gpd;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(79, 148);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(44, 27);
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::WindowsFormsStartProject.Properties.Resources.euro;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(79, 111);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(44, 27);
            this.pictureBox8.TabIndex = 14;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::WindowsFormsStartProject.Properties.Resources.usa;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(79, 78);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(44, 27);
            this.pictureBox9.TabIndex = 13;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = global::WindowsFormsStartProject.Properties.Resources.cad;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(79, 39);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(44, 27);
            this.pictureBox10.TabIndex = 12;
            this.pictureBox10.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = global::WindowsFormsStartProject.Properties.Resources.cad;
            this.label2.Location = new System.Drawing.Point(100, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 11;
            // 
            // toBrl
            // 
            this.toBrl.AutoSize = true;
            this.toBrl.Location = new System.Drawing.Point(17, 183);
            this.toBrl.Name = "toBrl";
            this.toBrl.Size = new System.Drawing.Size(54, 20);
            this.toBrl.TabIndex = 4;
            this.toBrl.TabStop = true;
            this.toBrl.Text = "BRL";
            this.toBrl.UseVisualStyleBackColor = true;
            // 
            // toGbp
            // 
            this.toGbp.AutoSize = true;
            this.toGbp.Location = new System.Drawing.Point(17, 148);
            this.toGbp.Name = "toGbp";
            this.toGbp.Size = new System.Drawing.Size(56, 20);
            this.toGbp.TabIndex = 3;
            this.toGbp.TabStop = true;
            this.toGbp.Text = "GBP";
            this.toGbp.UseVisualStyleBackColor = true;
            // 
            // toEur
            // 
            this.toEur.AutoSize = true;
            this.toEur.Location = new System.Drawing.Point(17, 111);
            this.toEur.Name = "toEur";
            this.toEur.Size = new System.Drawing.Size(57, 20);
            this.toEur.TabIndex = 2;
            this.toEur.TabStop = true;
            this.toEur.Text = "EUR";
            this.toEur.UseVisualStyleBackColor = true;
            // 
            // toUsd
            // 
            this.toUsd.AutoSize = true;
            this.toUsd.Location = new System.Drawing.Point(17, 78);
            this.toUsd.Name = "toUsd";
            this.toUsd.Size = new System.Drawing.Size(57, 20);
            this.toUsd.TabIndex = 1;
            this.toUsd.TabStop = true;
            this.toUsd.Text = "USD";
            this.toUsd.UseVisualStyleBackColor = true;
            this.toUsd.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // toCad
            // 
            this.toCad.AutoSize = true;
            this.toCad.Location = new System.Drawing.Point(17, 39);
            this.toCad.Name = "toCad";
            this.toCad.Size = new System.Drawing.Size(56, 20);
            this.toCad.TabIndex = 0;
            this.toCad.TabStop = true;
            this.toCad.Text = "CAD";
            this.toCad.UseVisualStyleBackColor = true;
            // 
            // groupFrom
            // 
            this.groupFrom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupFrom.Controls.Add(this.pictureBox5);
            this.groupFrom.Controls.Add(this.pictureBox3);
            this.groupFrom.Controls.Add(this.pictureBox4);
            this.groupFrom.Controls.Add(this.pictureBox2);
            this.groupFrom.Controls.Add(this.pictureBox1);
            this.groupFrom.Controls.Add(this.label1);
            this.groupFrom.Controls.Add(this.fromBrl);
            this.groupFrom.Controls.Add(this.fromGbp);
            this.groupFrom.Controls.Add(this.fromEur);
            this.groupFrom.Controls.Add(this.fromUsd);
            this.groupFrom.Controls.Add(this.fromCad);
            this.groupFrom.Location = new System.Drawing.Point(28, 44);
            this.groupFrom.Name = "groupFrom";
            this.groupFrom.Size = new System.Drawing.Size(153, 216);
            this.groupFrom.TabIndex = 0;
            this.groupFrom.TabStop = false;
            this.groupFrom.Text = "FROM";
            this.groupFrom.Enter += new System.EventHandler(this.groupFrom_Enter);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::WindowsFormsStartProject.Properties.Resources.brl;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(80, 183);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(44, 27);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::WindowsFormsStartProject.Properties.Resources.gpd;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(80, 148);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 27);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::WindowsFormsStartProject.Properties.Resources.euro;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(80, 111);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 27);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WindowsFormsStartProject.Properties.Resources.usa;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(80, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 27);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsStartProject.Properties.Resources.cad;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(80, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 27);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::WindowsFormsStartProject.Properties.Resources.cad;
            this.label1.Location = new System.Drawing.Point(92, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 5;
            // 
            // fromBrl
            // 
            this.fromBrl.AutoSize = true;
            this.fromBrl.Location = new System.Drawing.Point(16, 183);
            this.fromBrl.Name = "fromBrl";
            this.fromBrl.Size = new System.Drawing.Size(54, 20);
            this.fromBrl.TabIndex = 4;
            this.fromBrl.Text = "BRL";
            this.fromBrl.UseVisualStyleBackColor = true;
            // 
            // fromGbp
            // 
            this.fromGbp.AutoSize = true;
            this.fromGbp.Location = new System.Drawing.Point(17, 148);
            this.fromGbp.Name = "fromGbp";
            this.fromGbp.Size = new System.Drawing.Size(56, 20);
            this.fromGbp.TabIndex = 3;
            this.fromGbp.Text = "GBP";
            this.fromGbp.UseVisualStyleBackColor = true;
            this.fromGbp.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // fromEur
            // 
            this.fromEur.AutoSize = true;
            this.fromEur.Location = new System.Drawing.Point(17, 111);
            this.fromEur.Name = "fromEur";
            this.fromEur.Size = new System.Drawing.Size(57, 20);
            this.fromEur.TabIndex = 2;
            this.fromEur.Text = "EUR";
            this.fromEur.UseVisualStyleBackColor = true;
            // 
            // fromUsd
            // 
            this.fromUsd.AutoSize = true;
            this.fromUsd.Location = new System.Drawing.Point(16, 78);
            this.fromUsd.Name = "fromUsd";
            this.fromUsd.Size = new System.Drawing.Size(57, 20);
            this.fromUsd.TabIndex = 1;
            this.fromUsd.Text = "USD";
            this.fromUsd.UseVisualStyleBackColor = true;
            // 
            // fromCad
            // 
            this.fromCad.AutoSize = true;
            this.fromCad.Location = new System.Drawing.Point(18, 39);
            this.fromCad.Name = "fromCad";
            this.fromCad.Size = new System.Drawing.Size(56, 20);
            this.fromCad.TabIndex = 0;
            this.fromCad.Text = "CAD";
            this.fromCad.UseVisualStyleBackColor = true;
            this.fromCad.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // MoneyExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 380);
            this.Controls.Add(this.groupTo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupFrom);
            this.Name = "MoneyExchange";
            this.Text = "MoneyEx - Daniel Scholtz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MoneyExchange_FormClosing);
            this.Load += new System.EventHandler(this.MoneyExchange_Load);
            this.groupTo.ResumeLayout(false);
            this.groupTo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.groupFrom.ResumeLayout(false);
            this.groupFrom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupFrom;
        private System.Windows.Forms.RadioButton fromBrl;
        private System.Windows.Forms.RadioButton fromGbp;
        private System.Windows.Forms.RadioButton fromEur;
        private System.Windows.Forms.RadioButton fromUsd;
        private System.Windows.Forms.RadioButton fromCad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupTo;
        private System.Windows.Forms.RadioButton toBrl;
        private System.Windows.Forms.RadioButton toGbp;
        private System.Windows.Forms.RadioButton toEur;
        private System.Windows.Forms.RadioButton toUsd;
        private System.Windows.Forms.RadioButton toCad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
    }
}