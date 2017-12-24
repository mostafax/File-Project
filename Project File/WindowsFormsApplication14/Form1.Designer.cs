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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Display = new System.Windows.Forms.Panel();
            this.Canell = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DisplayHeading = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addnewbook = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AuthorNumTextBox = new System.Windows.Forms.TextBox();
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
            this.SearchingPanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.TXT_Searching = new System.Windows.Forms.TextBox();
            this.BTN_Searching = new System.Windows.Forms.Button();
            this.SearchingTextBox = new System.Windows.Forms.TextBox();
            this.NameSearching = new System.Windows.Forms.Panel();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.aftersearch = new System.Windows.Forms.TextBox();
            this.namesearchingbutton = new System.Windows.Forms.Button();
            this.NameSearchingtextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddingAuthorPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.AddingnewAuthor = new System.Windows.Forms.Button();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DisplayingAuthors = new System.Windows.Forms.Panel();
            this.AuthorsTextBos = new System.Windows.Forms.TextBox();
            this.Displaying_BTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.Display.SuspendLayout();
            this.addnewbook.SuspendLayout();
            this.Main.SuspendLayout();
            this.SearchingPanel.SuspendLayout();
            this.NameSearching.SuspendLayout();
            this.AddingAuthorPanel.SuspendLayout();
            this.DisplayingAuthors.SuspendLayout();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.Transparent;
            this.Display.Controls.Add(this.button7);
            this.Display.Controls.Add(this.Canell);
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
            // Canell
            // 
            this.Canell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Canell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Canell.ForeColor = System.Drawing.Color.DarkBlue;
            this.Canell.Location = new System.Drawing.Point(216, 309);
            this.Canell.Name = "Canell";
            this.Canell.Size = new System.Drawing.Size(78, 26);
            this.Canell.TabIndex = 3;
            this.Canell.Text = "Cancel";
            this.Canell.UseVisualStyleBackColor = true;
            this.Canell.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkBlue;
            this.button2.Location = new System.Drawing.Point(171, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Display";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // DisplayHeading
            // 
            this.DisplayHeading.AutoSize = true;
            this.DisplayHeading.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayHeading.ForeColor = System.Drawing.Color.DarkBlue;
            this.DisplayHeading.Location = new System.Drawing.Point(154, 58);
            this.DisplayHeading.Name = "DisplayHeading";
            this.DisplayHeading.Size = new System.Drawing.Size(205, 23);
            this.DisplayHeading.TabIndex = 1;
            this.DisplayHeading.Text = "Displaying All Books";
            this.DisplayHeading.Click += new System.EventHandler(this.DisplayHeading_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 105);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(248, 142);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // addnewbook
            // 
            this.addnewbook.BackColor = System.Drawing.Color.Transparent;
            this.addnewbook.Controls.Add(this.button10);
            this.addnewbook.Controls.Add(this.CancelButton);
            this.addnewbook.Controls.Add(this.AuthorNumTextBox);
            this.addnewbook.Controls.Add(this.PublishYearTextBox);
            this.addnewbook.Controls.Add(this.BookNameTextBox);
            this.addnewbook.Controls.Add(this.SerialTextBox);
            this.addnewbook.Controls.Add(this.label1);
            this.addnewbook.Controls.Add(this.btn);
            this.addnewbook.Controls.Add(this.label5);
            this.addnewbook.Controls.Add(this.label4);
            this.addnewbook.Controls.Add(this.label3);
            this.addnewbook.Controls.Add(this.label2);
            this.addnewbook.Location = new System.Drawing.Point(0, 0);
            this.addnewbook.Margin = new System.Windows.Forms.Padding(2);
            this.addnewbook.Name = "addnewbook";
            this.addnewbook.Size = new System.Drawing.Size(512, 370);
            this.addnewbook.TabIndex = 0;
            this.addnewbook.Visible = false;
            this.addnewbook.Paint += new System.Windows.Forms.PaintEventHandler(this.add_Paint);
            // 
            // CancelButton
            // 
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.CancelButton.Location = new System.Drawing.Point(263, 297);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 38);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AuthorNumTextBox
            // 
            this.AuthorNumTextBox.Location = new System.Drawing.Point(248, 239);
            this.AuthorNumTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AuthorNumTextBox.Name = "AuthorNumTextBox";
            this.AuthorNumTextBox.Size = new System.Drawing.Size(157, 20);
            this.AuthorNumTextBox.TabIndex = 9;
            this.AuthorNumTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // PublishYearTextBox
            // 
            this.PublishYearTextBox.Location = new System.Drawing.Point(248, 202);
            this.PublishYearTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PublishYearTextBox.Name = "PublishYearTextBox";
            this.PublishYearTextBox.Size = new System.Drawing.Size(157, 20);
            this.PublishYearTextBox.TabIndex = 8;
            this.PublishYearTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.Location = new System.Drawing.Point(248, 166);
            this.BookNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(157, 20);
            this.BookNameTextBox.TabIndex = 7;
            this.BookNameTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // SerialTextBox
            // 
            this.SerialTextBox.Location = new System.Drawing.Point(248, 127);
            this.SerialTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SerialTextBox.Name = "SerialTextBox";
            this.SerialTextBox.Size = new System.Drawing.Size(157, 20);
            this.SerialTextBox.TabIndex = 6;
            this.SerialTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn
            // 
            this.btn.Enabled = false;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn.Location = new System.Drawing.Point(148, 297);
            this.btn.Margin = new System.Windows.Forms.Padding(2);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(93, 38);
            this.btn.TabIndex = 5;
            this.btn.Text = "Add";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(153, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adding new book";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(93, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Author Number";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(99, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Publish Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(99, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(93, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial Number";
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.Transparent;
            this.Main.Controls.Add(this.button5);
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
            this.AuthorCheckBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorCheckBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.AuthorCheckBox.Location = new System.Drawing.Point(213, 144);
            this.AuthorCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.AuthorCheckBox.Name = "AuthorCheckBox";
            this.AuthorCheckBox.Size = new System.Drawing.Size(77, 22);
            this.AuthorCheckBox.TabIndex = 4;
            this.AuthorCheckBox.Text = "Author";
            this.AuthorCheckBox.UseVisualStyleBackColor = true;
            this.AuthorCheckBox.CheckedChanged += new System.EventHandler(this.AuthorCheckBox_CheckedChanged);
            // 
            // BookCheckBox
            // 
            this.BookCheckBox.AutoSize = true;
            this.BookCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.BookCheckBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookCheckBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.BookCheckBox.Location = new System.Drawing.Point(213, 104);
            this.BookCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.BookCheckBox.Name = "BookCheckBox";
            this.BookCheckBox.Size = new System.Drawing.Size(72, 22);
            this.BookCheckBox.TabIndex = 3;
            this.BookCheckBox.Text = "Books";
            this.BookCheckBox.UseVisualStyleBackColor = false;
            this.BookCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SearchingButton
            // 
            this.SearchingButton.Enabled = false;
            this.SearchingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchingButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchingButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.SearchingButton.Location = new System.Drawing.Point(327, 241);
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
            this.DisplayingButton.Enabled = false;
            this.DisplayingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisplayingButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayingButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.DisplayingButton.Location = new System.Drawing.Point(213, 241);
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
            this.AddingButton.Enabled = false;
            this.AddingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddingButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddingButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.AddingButton.Location = new System.Drawing.Point(96, 241);
            this.AddingButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddingButton.Name = "AddingButton";
            this.AddingButton.Size = new System.Drawing.Size(85, 48);
            this.AddingButton.TabIndex = 0;
            this.AddingButton.Text = "Add";
            this.AddingButton.UseVisualStyleBackColor = true;
            this.AddingButton.Click += new System.EventHandler(this.Addddd_Click);
            // 
            // SearchingPanel
            // 
            this.SearchingPanel.BackColor = System.Drawing.Color.Transparent;
            this.SearchingPanel.Controls.Add(this.label11);
            this.SearchingPanel.Controls.Add(this.button4);
            this.SearchingPanel.Controls.Add(this.BTN_Cancel);
            this.SearchingPanel.Controls.Add(this.TXT_Searching);
            this.SearchingPanel.Controls.Add(this.BTN_Searching);
            this.SearchingPanel.Controls.Add(this.SearchingTextBox);
            this.SearchingPanel.Location = new System.Drawing.Point(0, 0);
            this.SearchingPanel.Name = "SearchingPanel";
            this.SearchingPanel.Size = new System.Drawing.Size(512, 370);
            this.SearchingPanel.TabIndex = 11;
            this.SearchingPanel.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(461, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 25);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Cancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Cancel.ForeColor = System.Drawing.Color.DarkBlue;
            this.BTN_Cancel.Location = new System.Drawing.Point(216, 305);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(80, 30);
            this.BTN_Cancel.TabIndex = 4;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // TXT_Searching
            // 
            this.TXT_Searching.Location = new System.Drawing.Point(130, 148);
            this.TXT_Searching.Multiline = true;
            this.TXT_Searching.Name = "TXT_Searching";
            this.TXT_Searching.ReadOnly = true;
            this.TXT_Searching.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXT_Searching.Size = new System.Drawing.Size(237, 140);
            this.TXT_Searching.TabIndex = 3;
            this.TXT_Searching.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_Searching.TextChanged += new System.EventHandler(this.TXT_Searching_TextChanged);
            // 
            // BTN_Searching
            // 
            this.BTN_Searching.Enabled = false;
            this.BTN_Searching.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Searching.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Searching.ForeColor = System.Drawing.Color.DarkBlue;
            this.BTN_Searching.Location = new System.Drawing.Point(211, 109);
            this.BTN_Searching.Name = "BTN_Searching";
            this.BTN_Searching.Size = new System.Drawing.Size(74, 31);
            this.BTN_Searching.TabIndex = 2;
            this.BTN_Searching.Text = "Search";
            this.BTN_Searching.UseVisualStyleBackColor = true;
            this.BTN_Searching.Click += new System.EventHandler(this.BTN_Searching_Click);
            // 
            // SearchingTextBox
            // 
            this.SearchingTextBox.BackColor = System.Drawing.Color.Snow;
            this.SearchingTextBox.Location = new System.Drawing.Point(183, 78);
            this.SearchingTextBox.Name = "SearchingTextBox";
            this.SearchingTextBox.Size = new System.Drawing.Size(129, 20);
            this.SearchingTextBox.TabIndex = 1;
            this.SearchingTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // NameSearching
            // 
            this.NameSearching.BackColor = System.Drawing.Color.Transparent;
            this.NameSearching.Controls.Add(this.button6);
            this.NameSearching.Controls.Add(this.cancel_btn);
            this.NameSearching.Controls.Add(this.aftersearch);
            this.NameSearching.Controls.Add(this.namesearchingbutton);
            this.NameSearching.Controls.Add(this.NameSearchingtextbox);
            this.NameSearching.Controls.Add(this.label6);
            this.NameSearching.Location = new System.Drawing.Point(0, 0);
            this.NameSearching.Name = "NameSearching";
            this.NameSearching.Size = new System.Drawing.Size(509, 370);
            this.NameSearching.TabIndex = 4;
            this.NameSearching.Visible = false;
            // 
            // cancel_btn
            // 
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.Color.DarkBlue;
            this.cancel_btn.Location = new System.Drawing.Point(213, 312);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(77, 32);
            this.cancel_btn.TabIndex = 4;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // aftersearch
            // 
            this.aftersearch.Location = new System.Drawing.Point(136, 170);
            this.aftersearch.Multiline = true;
            this.aftersearch.Name = "aftersearch";
            this.aftersearch.ReadOnly = true;
            this.aftersearch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.aftersearch.Size = new System.Drawing.Size(230, 134);
            this.aftersearch.TabIndex = 3;
            this.aftersearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.aftersearch.TextChanged += new System.EventHandler(this.aftersearch_TextChanged);
            // 
            // namesearchingbutton
            // 
            this.namesearchingbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.namesearchingbutton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namesearchingbutton.ForeColor = System.Drawing.Color.DarkBlue;
            this.namesearchingbutton.Location = new System.Drawing.Point(213, 132);
            this.namesearchingbutton.Name = "namesearchingbutton";
            this.namesearchingbutton.Size = new System.Drawing.Size(77, 29);
            this.namesearchingbutton.TabIndex = 2;
            this.namesearchingbutton.Text = "Search";
            this.namesearchingbutton.UseVisualStyleBackColor = true;
            this.namesearchingbutton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // NameSearchingtextbox
            // 
            this.NameSearchingtextbox.Location = new System.Drawing.Point(158, 106);
            this.NameSearchingtextbox.Name = "NameSearchingtextbox";
            this.NameSearchingtextbox.Size = new System.Drawing.Size(179, 20);
            this.NameSearchingtextbox.TabIndex = 1;
            this.NameSearchingtextbox.TextChanged += new System.EventHandler(this.NameSearchingtextbox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(84, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(357, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Enter Author Name to Search for his books";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // AddingAuthorPanel
            // 
            this.AddingAuthorPanel.BackColor = System.Drawing.Color.Transparent;
            this.AddingAuthorPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddingAuthorPanel.Controls.Add(this.button9);
            this.AddingAuthorPanel.Controls.Add(this.button3);
            this.AddingAuthorPanel.Controls.Add(this.AddingnewAuthor);
            this.AddingAuthorPanel.Controls.Add(this.EmailTextBox);
            this.AddingAuthorPanel.Controls.Add(this.NameTextBox);
            this.AddingAuthorPanel.Controls.Add(this.IDTextBox);
            this.AddingAuthorPanel.Controls.Add(this.label10);
            this.AddingAuthorPanel.Controls.Add(this.label9);
            this.AddingAuthorPanel.Controls.Add(this.label8);
            this.AddingAuthorPanel.Controls.Add(this.label7);
            this.AddingAuthorPanel.Location = new System.Drawing.Point(0, 0);
            this.AddingAuthorPanel.Name = "AddingAuthorPanel";
            this.AddingAuthorPanel.Size = new System.Drawing.Size(512, 370);
            this.AddingAuthorPanel.TabIndex = 5;
            this.AddingAuthorPanel.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkBlue;
            this.button3.Location = new System.Drawing.Point(295, 289);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 30);
            this.button3.TabIndex = 8;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddingnewAuthor
            // 
            this.AddingnewAuthor.BackColor = System.Drawing.Color.Transparent;
            this.AddingnewAuthor.Enabled = false;
            this.AddingnewAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddingnewAuthor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddingnewAuthor.ForeColor = System.Drawing.Color.DarkBlue;
            this.AddingnewAuthor.Location = new System.Drawing.Point(158, 289);
            this.AddingnewAuthor.Name = "AddingnewAuthor";
            this.AddingnewAuthor.Size = new System.Drawing.Size(86, 30);
            this.AddingnewAuthor.TabIndex = 7;
            this.AddingnewAuthor.Text = "Add";
            this.AddingnewAuthor.UseVisualStyleBackColor = false;
            this.AddingnewAuthor.Click += new System.EventHandler(this.AddingnewAuthor_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.White;
            this.EmailTextBox.Location = new System.Drawing.Point(221, 227);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(184, 20);
            this.EmailTextBox.TabIndex = 6;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.White;
            this.NameTextBox.Location = new System.Drawing.Point(221, 186);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(184, 20);
            this.NameTextBox.TabIndex = 5;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // IDTextBox
            // 
            this.IDTextBox.BackColor = System.Drawing.Color.White;
            this.IDTextBox.Location = new System.Drawing.Point(221, 146);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(184, 20);
            this.IDTextBox.TabIndex = 4;
            this.IDTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkBlue;
            this.label10.Location = new System.Drawing.Point(85, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "Author\'s E-mail";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(85, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Author\'s Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(85, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Author\'s ID";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(91, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(326, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Adding New Author to the List";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // DisplayingAuthors
            // 
            this.DisplayingAuthors.BackColor = System.Drawing.Color.Transparent;
            this.DisplayingAuthors.Controls.Add(this.button8);
            this.DisplayingAuthors.Controls.Add(this.label12);
            this.DisplayingAuthors.Controls.Add(this.AuthorsTextBos);
            this.DisplayingAuthors.Controls.Add(this.Displaying_BTN);
            this.DisplayingAuthors.Controls.Add(this.button1);
            this.DisplayingAuthors.Location = new System.Drawing.Point(0, 0);
            this.DisplayingAuthors.Name = "DisplayingAuthors";
            this.DisplayingAuthors.Size = new System.Drawing.Size(512, 370);
            this.DisplayingAuthors.TabIndex = 5;
            this.DisplayingAuthors.Visible = false;
            // 
            // AuthorsTextBos
            // 
            this.AuthorsTextBos.BackColor = System.Drawing.Color.White;
            this.AuthorsTextBos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorsTextBos.ForeColor = System.Drawing.Color.Black;
            this.AuthorsTextBos.Location = new System.Drawing.Point(136, 103);
            this.AuthorsTextBos.Multiline = true;
            this.AuthorsTextBos.Name = "AuthorsTextBos";
            this.AuthorsTextBos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AuthorsTextBos.Size = new System.Drawing.Size(237, 146);
            this.AuthorsTextBos.TabIndex = 2;
            this.AuthorsTextBos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AuthorsTextBos.TextChanged += new System.EventHandler(this.AuthorsTextBos_TextChanged);
            // 
            // Displaying_BTN
            // 
            this.Displaying_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Displaying_BTN.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Displaying_BTN.ForeColor = System.Drawing.Color.DarkBlue;
            this.Displaying_BTN.Location = new System.Drawing.Point(189, 264);
            this.Displaying_BTN.Name = "Displaying_BTN";
            this.Displaying_BTN.Size = new System.Drawing.Size(133, 42);
            this.Displaying_BTN.TabIndex = 1;
            this.Displaying_BTN.Text = "Display";
            this.Displaying_BTN.UseVisualStyleBackColor = true;
            this.Displaying_BTN.Click += new System.EventHandler(this.Displaying_BTN_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(219, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkBlue;
            this.label11.Location = new System.Drawing.Point(160, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(199, 23);
            this.label11.TabIndex = 6;
            this.label11.Text = "Publish Year Search";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(461, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 25);
            this.button5.TabIndex = 6;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(461, 28);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(25, 25);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(461, 32);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(25, 25);
            this.button7.TabIndex = 7;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkBlue;
            this.label12.Location = new System.Drawing.Point(166, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(191, 23);
            this.label12.TabIndex = 3;
            this.label12.Text = "Displaying Authors";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Location = new System.Drawing.Point(461, 28);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(25, 25);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.Location = new System.Drawing.Point(461, 37);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(25, 25);
            this.button9.TabIndex = 9;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.Location = new System.Drawing.Point(461, 28);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(25, 25);
            this.button10.TabIndex = 11;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(511, 370);
            this.Controls.Add(this.addnewbook);
            this.Controls.Add(this.NameSearching);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.DisplayingAuthors);
            this.Controls.Add(this.SearchingPanel);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.AddingAuthorPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Books Managment System";
            this.Display.ResumeLayout(false);
            this.Display.PerformLayout();
            this.addnewbook.ResumeLayout(false);
            this.addnewbook.PerformLayout();
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.SearchingPanel.ResumeLayout(false);
            this.SearchingPanel.PerformLayout();
            this.NameSearching.ResumeLayout(false);
            this.NameSearching.PerformLayout();
            this.AddingAuthorPanel.ResumeLayout(false);
            this.AddingAuthorPanel.PerformLayout();
            this.DisplayingAuthors.ResumeLayout(false);
            this.DisplayingAuthors.PerformLayout();
            this.ResumeLayout(false);

        }

        private void button_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel Display;
        private System.Windows.Forms.Panel addnewbook;
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
        private System.Windows.Forms.TextBox AuthorNumTextBox;
        private System.Windows.Forms.TextBox PublishYearTextBox;
        private System.Windows.Forms.TextBox BookNameTextBox;
        private System.Windows.Forms.TextBox SerialTextBox;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.CheckBox AuthorCheckBox;
        private System.Windows.Forms.CheckBox BookCheckBox;
        private System.Windows.Forms.Label DisplayHeading;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Canell;
        private System.Windows.Forms.Panel SearchingPanel;
        private System.Windows.Forms.TextBox SearchingTextBox;
        private System.Windows.Forms.TextBox TXT_Searching;
        private System.Windows.Forms.Button BTN_Searching;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Panel NameSearching;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button namesearchingbutton;
        private System.Windows.Forms.TextBox NameSearchingtextbox;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.TextBox aftersearch;
        private System.Windows.Forms.Panel AddingAuthorPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button AddingnewAuthor;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Panel DisplayingAuthors;
        private System.Windows.Forms.TextBox AuthorsTextBos;
        private System.Windows.Forms.Button Displaying_BTN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}

