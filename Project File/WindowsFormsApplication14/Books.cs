
using System.IO;

static public class BooksFunctions
{
    static public void write(Book b) //To write new book in the File
    {
        FileStream FS = new FileStream("Book.txt", FileMode.Append);
        StreamWriter SW = new StreamWriter(FS);
        string str = b.serialNo + "@" + b.bookName + "@" + b.publishYear + "@" + b.authorNo + "#";
        SW.Write(str);
        SW.Close();
    }
    static public Book[] read() // To read all Books in the file inorder to display them
    {
        if (!(File.Exists("Book.txt")))
        {                                     //Inorder to handle the existence of the file
            return null;
        }
        FileStream fs = new FileStream("Book.txt", FileMode.Open);
        StreamReader sr = new StreamReader(fs);
        if (fs.Length==0)                        //If the Books File exists but it's empty
        {
            sr.Close();
            return null;
        }
        string[] records, fields;
        records = sr.ReadToEnd().Split('#');
        Book[] books = new Book[records.Length-1];
        for (int i = 0; i < records.Length-1 ; i++)
        {
            fields = records[i].Split('@');  //to split each record into fields
            if (fields.Length <= 1) continue;
            books[i].serialNo = fields[0];
            books[i].bookName = fields[1];
            books[i].publishYear = fields[2];
            books[i].authorNo = fields[3];
        }
        sr.Close();
        return books;
    }
    static public Book[] Search(string s, int f)
    {
        if (!(File.Exists("Book.txt")))
        {                                  //Inorder to handle the existence of the file
            return null;
        }
        FileStream Fs = new FileStream("Book.txt", FileMode.Open);
        StreamReader sr = new StreamReader(Fs);
        if (Fs.Length == 0)                        //If the Books File exists but it's empty
        {
            sr.Close();
            return null;
        }
        string[] records, fields;
        int[] saver = new int[100];  //is used if their are more than 1 record to be displayed
        int x = 0;
        bool found = false;
        records = sr.ReadToEnd().Split('#'); //to put each and every record in the file in  records (Array of String)
        sr.Close();
        if (f == 1)            //To search for the publish year in the Books File
        {
            for (int i = 0; i < records.Length - 1; i++) //loop to search each record for the publish year entered
            {                                        //we loop on the length of the records-1 inorder not to access null after spliting
                fields = records[i].Split('@');
                if (s == fields[2])
                {
                    saver[x] = i;   //to store the number of the record if the publish year was found
                    found = true;
                    x++;
                }
            }
        }
        else if (f == 2)      //To search for the Author Number in the Books File
        {
            for (int i = 0; i < records.Length - 1; i++) //loop to search each record for the Author number entered
            {                                        //we loop on the length of the records-1 inorder not to access null after spliting
                fields = records[i].Split('@');
                if (s == fields[3])
                {
                    saver[x] = i;   //to store the number of the record if the Author number was found
                    found = true;
                    x++;
                }
            }
        }
        if (found == false)
        {
            return null;
        }
        Book[] books = new Book[x];   //To get all books struct found in the file of books according to the length of the integer array

        for (int i = 0; i < x; i++)
        {

            fields = records[saver[i]].Split('@'); //to split the records of the found Books after searching on (Publish Year/Author number)
            books[i].serialNo = fields[0];
            books[i].bookName = fields[1];
            books[i].publishYear = fields[2];
            books[i].authorNo = fields[3];
        }
        return books;

    }
    static public bool Book_Checker(Book B) //To check if there was a conflict in the Serial number of the book entered with another one already stored in the file
    {
        if(!(File.Exists("Book.txt"))){     //Inorder to handle the existence of the file
            return false;
        }
        FileStream fs = new FileStream("Book.txt", FileMode.Open);
        StreamReader sr = new StreamReader(fs);
        string[] Records, Fields;
        Records = sr.ReadToEnd().Split('#'); //To read all records in the books file
        sr.Close();
        bool founded = false;
        for(int i = 0; i < Records.Length-1; i++)  //Loop to check the serial number of each record inorder not to conflict the same serial number
        {
            Fields = Records[i].Split('@');
            if (B.serialNo == Fields[0])
            {
                founded = true;
                break;

            }
        }
        if (founded)
        {
            return true;
        }
        else return false;
    }


}
