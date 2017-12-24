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
        string year, name, serial, authnum, yearsearch, email;           //Strings to be used all over the program :)
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

        private void button1_Click(object sender, EventArgs e)          //Displaying Button in the Main Panel
        {
            if (BookCheckBox.Checked == true)   //To change panels between Main Panel and Displaying Books Panel
            {
                Display.Visible = true;
                Main.Visible = false;
            }
            else                               //To change panels between Main Panel and Dsiplaying Authors Panel
            {
                Main.Visible = false;
                DisplayingAuthors.Visible = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)       //Searching Button in the Main Panel
        {
            if (BookCheckBox.Checked == true)    //To Change panels between Main Panel and Searching Books Panel
            {
                Main.Visible = false;
                SearchingPanel.Visible = true;
            }
            else                                 //To Change panels between Main Panel and Searching Authors Panel
            {
                Main.Visible = false;
                NameSearching.Visible = true;
            }
        }

        private void Addddd_Click(object sender, EventArgs e)  //Adding Button in the Main Panel
        {
            if (BookCheckBox.Checked == true)   //To Change panels between Main Panel and Adding Books Panel
            {
                addnewbook.Visible = true;
                Main.Visible = false;

            }
            else                               //To Change panels between Main Panel and Adding Authors Panel
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

        private void textBox1_TextChanged(object sender, EventArgs e)       //Serial Number of book TextBox
        {
            if (SerialTextBox.Text == "") return;
            int tmp = SerialTextBox.SelectionStart;                         //to access the position of the of text entering
            bool Checked = false;
            for (int i = 0; i < SerialTextBox.TextLength; i++)              //for checking whether the new text entered is Digit or not
            {
                if (!char.IsDigit(SerialTextBox.Text[i]))                   //ISDigit is a function to check if it's digit or not number
                {
                    SerialTextBox.Text = SerialTextBox.Text.Remove(i, 1);   //to remove the new text entered when it's not digit
                    Checked = true;
                    i--;
                }
            }
            if (Checked) tmp--;                      //to remove the text entered if the text is not Digit(number)
            SerialTextBox.SelectionStart = tmp;      //to modify the position if the user made a wrong entry
            serial = SerialTextBox.Text;             //to copy the string in the textbox to the serial string
            CheckTextBoxes();                        //to call checktextboxes Function
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            AuthorNumTextBox.MaxLength = 5;                                             //to limit the lenght of the textbox
            if (AuthorNumTextBox.Text == "") return;
            int tmp = AuthorNumTextBox.SelectionStart;                                  //to access the position of the of text entering
            bool Checked = false;
            for (int i = 0; i < AuthorNumTextBox.TextLength; i++)                       //for checking whether the new text entered is Digit or not
            {
                if (!char.IsDigit(AuthorNumTextBox.Text[i]))                            //ISDigit is a function to check if it's digit or not
                {
                    AuthorNumTextBox.Text = AuthorNumTextBox.Text.Remove(i, 1);         //to remove the new text entered when it's not digit(number)
                    Checked = true;
                    i--;
                }
            }
            if (Checked) tmp--;                                  //to remove the text entered if the text is not Digit(number)
            AuthorNumTextBox.SelectionStart = tmp;               //to modify the position if the user made a wrong entry
            authnum = AuthorNumTextBox.Text;                     //to copy the string in the textbox to the authnum string
            CheckTextBoxes();                                    //to call checktextboxes Function
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)       //book checkbox
        {
            if (BookCheckBox.Checked == true)          //condition to enable the buttons of the main panel when BookCheckBox was chosen
            {
                AuthorCheckBox.Checked = false;
                AddingButton.Enabled = true;
                DisplayingButton.Enabled = true;
                SearchingButton.Enabled = true;
            }
            if (BookCheckBox.Checked == false)         //condition to disable the buttons of the main panel when BookCheckBox was not chosen
            {
                AddingButton.Enabled = false;
                DisplayingButton.Enabled = false;
                SearchingButton.Enabled = false;
            }


        }

        private void CancelButton_Click(object sender, EventArgs e)            //cancel button of the addingnewbook panel
        {
            addnewbook.Visible = false;                       //to access the main panel again and hide the addingnewbook panel
            Main.Visible = true;
        }

        private void AuthorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AuthorCheckBox.Checked == true)    //condition to enable the buttons of the main panel if the AuthorCheckBox was chosen
            {
                BookCheckBox.Checked = false;
                AddingButton.Enabled = true;
                DisplayingButton.Enabled = true;
                SearchingButton.Enabled = true;
            }
            if (AuthorCheckBox.Checked == false)   //condition to disable the buttons of the main panel if the AuthorCheckBox was not chosen
            {
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

        private void button2_Click_1(object sender, EventArgs e)  //Displaying Button for Books
        {
            Book[] BookArray;                             //Array of struct of book
            BookArray = BooksFunctions.read();            //calling read() function
            if (BookArray == null)
            {
                MessageBox.Show("There are no Books to Display");      //If the Books File was empty
            }
            else
            {
                string[] Lines = new string[(BookArray.Length * 5) - 1];    //Array of strings to Put each field in a line with a seperator between each record
                int index = 0;
                for (int i = 0; i < BookArray.Length; i++)                  //Loop to put each field in the string array inorder to display them
                {
                    Lines[index++] = "Serial Number: " + BookArray[i].serialNo;
                    Lines[index++] = "Book Name: " + BookArray[i].bookName;
                    Lines[index++] = "Publish Year: " + BookArray[i].publishYear;
                    Lines[index++] = "Author Number: " + BookArray[i].authorNo;
                    if (i != BookArray.Length - 1)
                        Lines[index++] = "----------------------------------------";   //to handle the last record inorder not to display seperator line after the last record
                }
                textBox1.Lines = Lines;                                                //function textBox1.Lines is to put each single element in the array in a single line
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)           //Cancel button of the Displaying Book Panel inorder to enable the main panel again
        {
            Display.Visible = false;
            Main.Visible = true;
            textBox1.Text = "";
        }

        private void BTN_Searching_Click(object sender, EventArgs e)      //Searching for Publish Year Button
        {
            Book[] books;
            books = BooksFunctions.Search(yearsearch, 1);                 //to call searching function of the book by the Publish Year
            if (books == null)
            {
                MessageBox.Show("This Book is not found");
                TXT_Searching.Text = "";
            }
            else
            {
                string[] Lines = new string[(books.Length * 5) - 1];      //Array of strings to Put each field in a line with a seperator between each record
                int index = 0;
                for (int i = 0; i < books.Length; i++)                    //Loop to put each field in the string array inorder to display them
                {
                    Lines[index++] = "Serial Number: " + books[i].serialNo;
                    Lines[index++] = "Book Name: " + books[i].bookName;
                    Lines[index++] = "Publish Year: " + books[i].publishYear;
                    Lines[index++] = "Author Number: " + books[i].authorNo;
                    if (i != books.Length - 1)                              //to handle the last record inorder not to display seperator line after the last record
                        Lines[index++] = "----------------------------------------";
                }
                TXT_Searching.Lines = Lines;                                //function Searching.Lines is to put each single element in the array in a single line
                SearchingTextBox.Focus();                                   //To Handle a problem occurred when Displaying The Books inorder to change the mouse focus after displaying
            }
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)           //Cancel Button in the Book searching Panel 
        {
            SearchingPanel.Visible = false;
            Main.Visible = true;
            TXT_Searching.Text = "";
            SearchingTextBox.Text = "";
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)     //Book Searching Textbox
        {

            SearchingTextBox.MaxLength = 4;                                //To adjust the max length of the textbox
            BTN_Searching.Enabled = true;                                  //To Enable the Button after Changing the text in the textbox
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
        private void button1_Click_2(object sender, EventArgs e)        //Searching Button in the Author Name Search Panel
        {
            Book[] books;
            string num = AuthorFunctions.Searching_Author(name);
            books = BooksFunctions.Search(num, 2);                       //To call the Searching Function()
            if (books == null)
            {
                MessageBox.Show("Author name has no books available");
                aftersearch.Text = "";
            }
            else
            {
                string[] Lines = new string[(books.Length * 5) - 1];     //Array of strings to Put each field in a line with a seperator between each record
                int index = 0;
                for (int i = 0; i < books.Length; i++)                   //Loop to put each field in the string array inorder to display them
                {
                    Lines[index++] = "Serial Number: " + books[i].serialNo;
                    Lines[index++] = "Book Name: " + books[i].bookName;
                    Lines[index++] = "Publish Year: " + books[i].publishYear;
                    Lines[index++] = "Author Number: " + books[i].authorNo;
                    if (i != books.Length - 1)
                        Lines[index++] = "----------------------------------------";    //to handle the last record inorder not to display seperator line after the last record
                }
                aftersearch.Lines = Lines;          //function aftersearch.Lines is to put each single element in the array in a single line 
            }
        }
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            NameTextBox.MaxLength = 20;           //to Adjust the the Max Length of the Name TextBox
            name = NameTextBox.Text;
            CheckAuthorTextBoxes();               //To call the function for checking textboxes
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            EmailTextBox.MaxLength = 25;         //to Adjust the Max Length of the Email TextBox
            email = EmailTextBox.Text;
            CheckAuthorTextBoxes();               //to call the function for checking textboxes
        }
        private void AddingnewAuthor_Click(object sender, EventArgs e) //Button of Add in the new Author adding Panel
        {
            Author s;
            s.id = authnum;
            s.authorName = name;
            s.email = email;
            if (AuthorFunctions.Author_Checker(s))         //To call the Checker Function {Go to definition for more details :) }
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

        private void button3_Click(object sender, EventArgs e)      //Cancel Button in the Adding Author Panel
        {
            Main.Visible = true;
            AddingAuthorPanel.Visible = false;
        }

        private void cancel_btn_Click(object sender, EventArgs e)    //Cancel Button in the Author Name Searching Panel
        {
            Main.Visible = true;
            NameSearching.Visible = false;
            NameSearchingtextbox.Text = "";
            aftersearch.Text = "";
        }
        private void textBox3_TextChanged_1(object sender, EventArgs e)    //Author ID textbox in the Adding Panel
        {
            if (IDTextBox.Text == "") return;
            IDTextBox.MaxLength = 5;                                //To adjust the Max Length of the textbox
            int tmp = IDTextBox.SelectionStart;                     //to access the position of the of text entering
            bool check = false;
            for (int i = 0; i < IDTextBox.TextLength; i++)          //Loop for checking whether the new text entered is Digit or not
            {
                if (!char.IsDigit(IDTextBox.Text[i]))               //IsDigit is a function to Check the Char entered if it is a Digit (number) or not
                {
                    IDTextBox.Text = IDTextBox.Text.Remove(i, 1);   //To Remove the char if the char was not Digit (number)
                    check = true;
                    i--;
                }
            }
            if (check) tmp--;
            IDTextBox.SelectionStart = tmp;                         //To set the position of the text entry inorder to write new char smoothly
            authnum = IDTextBox.Text;
            CheckAuthorTextBoxes();                                 //To call Check Author Text Boxes function {for more details Go to definition :) }
        }
        private void NameSearchingtextbox_TextChanged(object sender, EventArgs e)   //Name Searching Text Box in Author Name Searching Panel
        {
            name = NameSearchingtextbox.Text;
            namesearchingbutton.Enabled = true;        //To enable the button after entering the string you wish to search for
        }

        private void aftersearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)    //Cancel Button in the Displaying Author Panel
        {
            Main.Visible = true;
            DisplayingAuthors.Visible = false;
            AuthorsTextBos.Text = "";
        }

        private void Displaying_BTN_Click(object sender, EventArgs e)    //Button to Display all Authors in the Displaying Author Panel
        {
            Author[] Authors;
            Authors = AuthorFunctions.Author_read();         //Calling the read function { For more details go to definition :) }
            if (Authors == null)
            {
                MessageBox.Show("There are no Authors to display");
            }
            else
            {
                string[] Lines = new string[(Authors.Length * 4) - 1];    //String Array to put each field in the the array + seperator between each record and -1 inorder not to put seperator in the last Line after the last record
                int index = 0;
                for (int i = 0; i < Authors.Length; i++)
                {
                    Lines[index++] = "Author ID: " + Authors[i].id.ToString();
                    Lines[index++] = "Author Name: " + Authors[i].authorName.ToString();
                    Lines[index++] = "Email: " + Authors[i].email.ToString();
                    if (i != Authors.Length - 1)
                        Lines[index++] = "----------------------------------------";   //To put seperator after each record except the last one
                }
                AuthorsTextBos.Lines = Lines;
            }

        }

        private void AuthorsTextBos_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClosingButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckAuthorTextBoxes()
        {
            if ((IDTextBox.Text != "") && (NameTextBox.Text != "") && (EmailTextBox.Text != ""))
            {
                AddingnewAuthor.Enabled = true; //If all textboxes are written the Adding button will be enabled
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
                btn.Enabled = true;    //If all textboxes are written the Adding button will be enabled
            }
            else
            {
                btn.Enabled = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e) //Publish Year Textbox
        {
            PublishYearTextBox.MaxLength = 4;                            //To adjust the Max Length of the Publish Year TextBox
            if (PublishYearTextBox.Text == "") return;
            int tmp = PublishYearTextBox.SelectionStart;                 //to access the position of the of text entering
            bool Checked = false;
            for (int i = 0; i < PublishYearTextBox.TextLength; i++)      //for checking whether the new text entered is Digit or not
            {
                if (!char.IsDigit(PublishYearTextBox.Text[i]))           //ISDigit is a function to check if it's digit or not
                {
                    PublishYearTextBox.Text = PublishYearTextBox.Text.Remove(i, 1);     //to remove the new text entered when it's not digit(number)
                    Checked = true;
                    i--;
                }
            }
            if (Checked) tmp--;
            PublishYearTextBox.SelectionStart = tmp;    //To set the new position of the text after removing
            year = PublishYearTextBox.Text;
            CheckTextBoxes();                           //to check the Text Boxes for more detials { go to definition :) }
        }

        private void textBox2_TextChanged(object sender, EventArgs e) //Book name textbox
        {
            name = BookNameTextBox.Text;
            CheckTextBoxes();
        }

        private void btn_Click(object sender, EventArgs e)  //Button of Adding new Book in the File
        {
            Book h;
            h.serialNo = serial;
            h.bookName = name;
            h.publishYear = year;
            h.authorNo = authnum;
            if (BooksFunctions.Book_Checker(h))            //To Check if there was a conflict in the Serial Number
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
            btn.Enabled = false;              //To disable the Button of Add after adding the new book

        }
    }
}
