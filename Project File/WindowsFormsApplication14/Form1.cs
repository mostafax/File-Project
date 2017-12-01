using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    public partial class MainForm : Form
    {
        string year, name, serial, authnum;
        public MainForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display.Visible = true;
            Main.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Addddd_Click(object sender, EventArgs e)
        {

            
            if (BookCheckBox.Checked == true)
            {
                add.Visible = true;
                Main.Visible = false;

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void add_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            serial = SerialTextBox.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            authnum = AuthorNameTextBox.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (BookCheckBox.Checked == true)
            {
                AuthorCheckBox.Enabled = false;
                AddingButton.Enabled = true;
                DisplayingButton.Enabled = true;
                SearchingButton.Enabled = true;
            }
            if (BookCheckBox.Checked == false)
            {
                AuthorCheckBox.Enabled = true;
                AddingButton.Enabled = false;
                DisplayingButton.Enabled = false;
                SearchingButton.Enabled = false;
            }
            

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            add.Visible = false;
            Main.Visible = true;
        }

        private void AuthorCheckBox_CheckedChanged(object sender, EventArgs e)
        {



            if (AuthorCheckBox.Checked == true)
            {
                BookCheckBox.Enabled = false;
                AddingButton.Enabled = true;
                DisplayingButton.Enabled = true;
                SearchingButton.Enabled = true;
            }
            if (AuthorCheckBox.Checked == false)
            {
                BookCheckBox.Enabled = true;
                AddingButton.Enabled = false;
                DisplayingButton.Enabled = false;
                SearchingButton.Enabled = false;
            }
        }

        private void DisplayHeading_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {



        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Book[] BookArray;
            BookArray = BooksFunctions.read();
            string[] Lines = new string[(BookArray.Length * 5) - 1];
            int index = 0;
            for (int i = 0; i < BookArray.Length; i++)
            {
                Lines[index++] = "Serial Number: " + BookArray[i].serialNo;
                Lines[index++] = "Book Name: " + BookArray[i].bookName;
                Lines[index++] = "Publish Year: " + BookArray[i].publishYear;
                Lines[index++] = "Author Number: " + BookArray[i].authorNo;
                if (i != BookArray.Length - 1)
                    Lines[index++] = "----------------------------------------";
            }
            textBox1.Lines = Lines;
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Display.Visible = false;
            Main.Visible = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            PublishYearTextBox.MaxLength = 4;
            year = PublishYearTextBox.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            name = BookNameTextBox.Text;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Book h;
            h.serialNo = serial;
            h.bookName = name;
            h.publishYear = year;
            h.authorNo = authnum;
            BooksFunctions.write(h);
            MessageBox.Show("Book successfully added");

        }
    }
}
