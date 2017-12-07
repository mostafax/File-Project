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
        string year, name, serial, authnum, yearsearch, email;
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
            if (BookCheckBox.Checked == true)
            {
                Display.Visible = true;
                Main.Visible = false;
            }
            else
            {
                Main.Visible = false;
                DisplayingAuthors.Visible = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (BookCheckBox.Checked == true)
            {
                Main.Visible = false;
                SearchingPanel.Visible = true;
            }
            else
            {
                Main.Visible = false;
                NameSearching.Visible = true;
            }
        }

        private void Addddd_Click(object sender, EventArgs e)
        {


            if (BookCheckBox.Checked == true)
            {
                addnewbook.Visible = true;
                Main.Visible = false;

            }
            else
            {
                Main.Visible = false;
                AddingAuthorPanel.Visible = true;
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
            if (SerialTextBox.Text == "") return;
            int tmp = SerialTextBox.SelectionStart;
            bool Checked = false;
            for (int i = 0; i < SerialTextBox.TextLength; i++)
            {
                if (!char.IsDigit(SerialTextBox.Text[i]))
                {
                    SerialTextBox.Text = SerialTextBox.Text.Remove(i, 1);
                    Checked = true;
                    i--;
                }
            }
            if (Checked) tmp--;
            SerialTextBox.SelectionStart = tmp;
            serial = SerialTextBox.Text;
            CheckTextBoxes();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            AuthorNumTextBox.MaxLength = 5;
            if (AuthorNumTextBox.Text == "") return;
            int tmp = AuthorNumTextBox.SelectionStart;
            bool Checked = false;
            for (int i = 0; i < AuthorNumTextBox.TextLength; i++)
            {
                if (!char.IsDigit(AuthorNumTextBox.Text[i]))
                {
                    AuthorNumTextBox.Text = AuthorNumTextBox.Text.Remove(i, 1);
                    Checked = true;
                    i--;
                }
            }
            if (Checked) tmp--;
            AuthorNumTextBox.SelectionStart = tmp;
            authnum = AuthorNumTextBox.Text;
            CheckTextBoxes();
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
            addnewbook.Visible = false;
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
            if (BookArray == null)
            {
                MessageBox.Show("There are no Books to Display");
            }
            else
            {
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
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Display.Visible = false;
            Main.Visible = true;
            textBox1.Text = "";
        }

        private void BTN_Searching_Click(object sender, EventArgs e)
        {
            Book[] books;
            books = BooksFunctions.Search(yearsearch, 1);
            if (books == null)
            {
                MessageBox.Show("This Book is not found");

            }
            else
            {
                string[] Lines = new string[(books.Length * 5) - 1];
                int index = 0;
                for (int i = 0; i < books.Length; i++)
                {
                    Lines[index++] = "Serial Number: " + books[i].serialNo;
                    Lines[index++] = "Book Name: " + books[i].bookName;
                    Lines[index++] = "Publish Year: " + books[i].publishYear;
                    Lines[index++] = "Author Number: " + books[i].authorNo;
                    if (i != books.Length - 1)
                        Lines[index++] = "----------------------------------------";
                }
                TXT_Searching.Lines = Lines;
            }
            SearchingTextBox.Text = "";
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            SearchingPanel.Visible = false;
            Main.Visible = true;
            TXT_Searching.Text = "";
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

            SearchingTextBox.MaxLength = 4;
            BTN_Searching.Enabled = true;
            if (SearchingTextBox.Text == "")
            {
                BTN_Searching.Enabled = false;
            }
            yearsearch = SearchingTextBox.Text;

        }

        private void TXT_Searching_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Book[] books;
            string num = AuthorFunctions.Searching_Author(name);
            books = BooksFunctions.Search(num, 2);
            if (books == null)
            {
                MessageBox.Show("Author name has no books available");
            }
            else
            {
                string[] Lines = new string[(books.Length * 5) - 1];
                int index = 0;
                for (int i = 0; i < books.Length; i++)
                {
                    Lines[index++] = "Serial Number: " + books[i].serialNo;
                    Lines[index++] = "Book Name: " + books[i].bookName;
                    Lines[index++] = "Publish Year: " + books[i].publishYear;
                    Lines[index++] = "Author Number: " + books[i].authorNo;
                    if (i != books.Length - 1)
                        Lines[index++] = "----------------------------------------";
                }
                aftersearch.Lines = Lines;

            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            NameTextBox.MaxLength = 20;
            name = NameTextBox.Text;
            CheckAuthorTextBoxes();
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            EmailTextBox.MaxLength = 25;
            email = EmailTextBox.Text;
            CheckAuthorTextBoxes();
        }

        private void AddingnewAuthor_Click(object sender, EventArgs e)
        {
            Author s;
            s.id = authnum;
            s.authorName = name;
            s.email = email;
            if (AuthorFunctions.Author_Checker(s))
            {
                MessageBox.Show("There was a conflict in Author ID and was unsuccssfully added Please try again");
            }
            else
            {
                AuthorFunctions.Write_Author(s);
                MessageBox.Show("Author was successfully added");
            }
            IDTextBox.Text = "";
            NameTextBox.Text = "";
            EmailTextBox.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main.Visible = true;
            AddingAuthorPanel.Visible = false;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Main.Visible = true;
            NameSearching.Visible = false;
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            if (IDTextBox.Text == "") return;
            IDTextBox.MaxLength = 5;
            int tmp = IDTextBox.SelectionStart;
            bool check = false;
            for (int i = 0; i < IDTextBox.TextLength; i++)
            {
                if (!char.IsDigit(IDTextBox.Text[i]))
                {
                    IDTextBox.Text = IDTextBox.Text.Remove(i, 1);
                    check = true;
                    i--;
                }
            }
            if (check) tmp--;
            IDTextBox.SelectionStart = tmp;
            authnum = IDTextBox.Text;
            CheckAuthorTextBoxes();

        }

        private void NameSearchingtextbox_TextChanged(object sender, EventArgs e)
        {
            name = NameSearchingtextbox.Text;
            namesearchingbutton.Enabled = true;
        }

        private void aftersearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Main.Visible = true;
            DisplayingAuthors.Visible = false;
            AuthorsTextBos.Text = "";
        }

        private void Displaying_BTN_Click(object sender, EventArgs e)
        {
            Author[] Authors;
            Authors = AuthorFunctions.Author_read();
            if (Authors == null)
            {
                MessageBox.Show("There are no Authors to display");
            }
            else
            {
                string[] Lines = new string[(Authors.Length * 4) - 1];
                int index = 0;
                for (int i = 0; i < Authors.Length; i++)
                {
                    Lines[index++] = "Author ID: " + Authors[i].id.ToString();
                    Lines[index++] = "Author Name: " + Authors[i].authorName.ToString();
                    Lines[index++] = "Email: " + Authors[i].email.ToString();
                    if (i != Authors.Length - 1)
                        Lines[index++] = "----------------------------------------";
                }
                AuthorsTextBos.Lines = Lines;
            }

        }

        private void AuthorsTextBos_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckAuthorTextBoxes()
        {
            if ((IDTextBox.Text != "") && (NameTextBox.Text != ""))
            {
                AddingnewAuthor.Enabled = true;
            }
            else
            {
                AddingnewAuthor.Enabled = false;
            }

        }

        private void CheckTextBoxes()
        {
            if ((SerialTextBox.Text != "") && (BookNameTextBox.Text != "") && (PublishYearTextBox.Text != "") && (AuthorNumTextBox.Text != ""))
            {
                btn.Enabled = true;
            }
            else
            {
                btn.Enabled = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            PublishYearTextBox.MaxLength = 4;
            if (PublishYearTextBox.Text == "") return;
            int tmp = PublishYearTextBox.SelectionStart;
            bool Checked = false;
            for (int i = 0; i < PublishYearTextBox.TextLength; i++)
            {
                if (!char.IsDigit(PublishYearTextBox.Text[i]))
                {
                    PublishYearTextBox.Text = PublishYearTextBox.Text.Remove(i, 1);
                    Checked = true;
                    i--;
                }
            }
            if (Checked) tmp--;
            PublishYearTextBox.SelectionStart = tmp;
            year = PublishYearTextBox.Text;
            CheckTextBoxes();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            name = BookNameTextBox.Text;
            CheckTextBoxes();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Book h;
            h.serialNo = serial;
            h.bookName = name;
            h.publishYear = year;
            h.authorNo = authnum;
            if (BooksFunctions.Book_Checker(h))
            {
                MessageBox.Show("There was a conflict in the Book serial number and was unsuccessfully added Please try again");
            }
            else
            {
                BooksFunctions.write(h);
                MessageBox.Show("Book successfully added");
            }
            AuthorNumTextBox.Text = "";
            SerialTextBox.Text = "";
            PublishYearTextBox.Text = "";
            BookNameTextBox.Text = "";
            btn.Enabled = false;

        }
    }
}
