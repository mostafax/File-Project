using System;

namespace WindowsFormsApplication14
{
    partial class MainForm
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
            this.Display = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.DisplayHeading = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AuthorNameTextBox = new System.Windows.Forms.TextBox();
            this.PublishYearTextBox = new System.Windows.Forms.TextBox();
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            this.SerialTextBox = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Main = new System.Windows.Forms.Panel();
            this.AuthorCheckBox = new System.Windows.Forms.CheckBox();
            this.BookCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchingButton = new System.Windows.Forms.Button();
            this.DisplayingButton = new System.Windows.Forms.Button();
            this.AddingButton = new System.Windows.Forms.Button();
            this.Display.SuspendLayout();
            this.add.SuspendLayout();
            this.Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.Controls.Add(this.button2);
            this.Display.Controls.Add(this.DisplayHeading);
            this.Display.Controls.Add(this.textBox1);
            this.Display.Location = new System.Drawing.Point(0, 0);
            this.Display.Margin = new System.Windows.Forms.Padding(2);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(512, 370);
            this.Display.TabIndex = 0;
            this.Display.Visible = false;
            this.Display.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 61);
            this.button2.TabIndex = 2;
            this.button2.Text = "DisplayAllBooks";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // DisplayHeading
            // 
            this.DisplayHeading.AutoSize = true;
            this.DisplayHeading.Location = new System.Drawing.Point(189, 43);
            this.DisplayHeading.Name = "DisplayHeading";
            this.DisplayHeading.Size = new System.Drawing.Size(100, 13);
            this.DisplayHeading.TabIndex = 1;
            this.DisplayHeading.Text = "Displaying All Books";
            this.DisplayHeading.Click += new System.EventHandler(this.DisplayHeading_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // add
            // 
            this.add.Controls.Add(this.CancelButton);
            this.add.Controls.Add(this.AuthorNameTextBox);
            this.add.Controls.Add(this.PublishYearTextBox);
            this.add.Controls.Add(this.BookNameTextBox);
            this.add.Controls.Add(this.SerialTextBox);
            this.add.Controls.Add(this.btn);
            this.add.Controls.Add(this.label5);
            this.add.Controls.Add(this.label4);
            this.add.Controls.Add(this.label3);
            this.add.Controls.Add(this.label2);
            this.add.Controls.Add(this.label1);
            this.add.Location = new System.Drawing.Point(0, 0);
            this.add.Margin = new System.Windows.Forms.Padding(2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(512, 370);
            this.add.TabIndex = 0;
            this.add.Visible = false;
            this.add.Paint += new System.Windows.Forms.PaintEventHandler(this.add_Paint);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(298, 266);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(68, 37);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AuthorNameTextBox
            // 
            this.AuthorNameTextBox.Location = new System.Drawing.Point(178, 208);
            this.AuthorNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AuthorNameTextBox.Name = "AuthorNameTextBox";
            this.AuthorNameTextBox.Size = new System.Drawing.Size(254, 20);
            this.AuthorNameTextBox.TabIndex = 9;
            this.AuthorNameTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // PublishYearTextBox
            // 
            this.PublishYearTextBox.Location = new System.Drawing.Point(178, 158);
            this.PublishYearTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PublishYearTextBox.Name = "PublishYearTextBox";
            this.PublishYearTextBox.Size = new System.Drawing.Size(254, 20);
            this.PublishYearTextBox.TabIndex = 8;
            this.PublishYearTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.Location = new System.Drawing.Point(178, 107);
            this.BookNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(254, 20);
            this.BookNameTextBox.TabIndex = 7;
            this.BookNameTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // SerialTextBox
            // 
            this.SerialTextBox.Location = new System.Drawing.Point(178, 58);
            this.SerialTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SerialTextBox.Name = "SerialTextBox";
            this.SerialTextBox.Size = new System.Drawing.Size(254, 20);
            this.SerialTextBox.TabIndex = 6;
            this.SerialTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(192, 266);
            this.btn.Margin = new System.Windows.Forms.Padding(2);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(71, 37);
            this.btn.TabIndex = 5;
            this.btn.Text = "Add";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(189, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adding new book";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Author Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Publish Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial Number";
            // 
            // Main
            // 
            this.Main.Controls.Add(this.AuthorCheckBox);
            this.Main.Controls.Add(this.BookCheckBox);
            this.Main.Controls.Add(this.SearchingButton);
            this.Main.Controls.Add(this.DisplayingButton);
            this.Main.Controls.Add(this.AddingButton);
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Margin = new System.Windows.Forms.Padding(2);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(512, 370);
            this.Main.TabIndex = 0;
            this.Main.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
            // 
            // AuthorCheckBox
            // 
            this.AuthorCheckBox.AutoSize = true;
            this.AuthorCheckBox.Location = new System.Drawing.Point(209, 121);
            this.AuthorCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.AuthorCheckBox.Name = "AuthorCheckBox";
            this.AuthorCheckBox.Size = new System.Drawing.Size(59, 17);
            this.AuthorCheckBox.TabIndex = 4;
            this.AuthorCheckBox.Text = "Author";
            this.AuthorCheckBox.UseVisualStyleBackColor = true;
            this.AuthorCheckBox.CheckedChanged += new System.EventHandler(this.AuthorCheckBox_CheckedChanged);
            // 
            // BookCheckBox
            // 
            this.BookCheckBox.AutoSize = true;
            this.BookCheckBox.Location = new System.Drawing.Point(209, 82);
            this.BookCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.BookCheckBox.Name = "BookCheckBox";
            this.BookCheckBox.Size = new System.Drawing.Size(54, 17);
            this.BookCheckBox.TabIndex = 3;
            this.BookCheckBox.Text = "Books";
            this.BookCheckBox.UseVisualStyleBackColor = true;
            this.BookCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SearchingButton
            // 
            this.SearchingButton.Location = new System.Drawing.Point(318, 241);
            this.SearchingButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchingButton.Name = "SearchingButton";
            this.SearchingButton.Size = new System.Drawing.Size(82, 48);
            this.SearchingButton.TabIndex = 2;
            this.SearchingButton.Text = "Search";
            this.SearchingButton.UseVisualStyleBackColor = true;
            this.SearchingButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // DisplayingButton
            // 
            this.DisplayingButton.Location = new System.Drawing.Point(192, 241);
            this.DisplayingButton.Margin = new System.Windows.Forms.Padding(2);
            this.DisplayingButton.Name = "DisplayingButton";
            this.DisplayingButton.Size = new System.Drawing.Size(84, 48);
            this.DisplayingButton.TabIndex = 1;
            this.DisplayingButton.Text = "Display";
            this.DisplayingButton.UseVisualStyleBackColor = true;
            this.DisplayingButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddingButton
            // 
            this.AddingButton.Location = new System.Drawing.Point(56, 241);
            this.AddingButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddingButton.Name = "AddingButton";
            this.AddingButton.Size = new System.Drawing.Size(85, 48);
            this.AddingButton.TabIndex = 0;
            this.AddingButton.Text = "Add";
            this.AddingButton.UseVisualStyleBackColor = true;
            this.AddingButton.Click += new System.EventHandler(this.Addddd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 370);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Main);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Books Managment System";
            this.Display.ResumeLayout(false);
            this.Display.PerformLayout();
            this.add.ResumeLayout(false);
            this.add.PerformLayout();
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.ResumeLayout(false);

        }

        private void button_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel Display;
        private System.Windows.Forms.Panel add;
        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Button AddingButton;
        private System.Windows.Forms.Button SearchingButton;
        private System.Windows.Forms.Button DisplayingButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox AuthorNameTextBox;
        private System.Windows.Forms.TextBox PublishYearTextBox;
        private System.Windows.Forms.TextBox BookNameTextBox;
        private System.Windows.Forms.TextBox SerialTextBox;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.CheckBox AuthorCheckBox;
        private System.Windows.Forms.CheckBox BookCheckBox;
        private System.Windows.Forms.Label DisplayHeading;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}

