
using System.IO;

static public class BooksFunctions
{
    static public void write(Book b)
    {

        FileStream FS = new FileStream("Book.txt", FileMode.Append);
        StreamWriter SW = new StreamWriter(FS);
        string str = b.serialNo + "@" + b.bookName + "@" + b.publishYear + "@" + b.authorNo + "#";
        SW.Write(str);
        SW.Close();

    }
    static public Book[] read()
    {
        FileStream fs = new FileStream("Book.txt", FileMode.Open);
        StreamReader sr = new StreamReader(fs);
        string[] records, fields;
        records = sr.ReadToEnd().Split('#');
        if(records.Length == 0)
        {
            return null;
        }
        Book[] books = new Book[records.Length - 1];
        for (int i = 0; i < records.Length - 1; i++)
        {
            fields = records[i].Split('@');
            if (fields.Length <= 1) continue;
            books[i].serialNo = fields[0];
            books[i].bookName = fields[1];
            books[i].publishYear = fields[2];
            books[i].authorNo = fields[3];
        }
        sr.Close();
        return books;
    }


}
