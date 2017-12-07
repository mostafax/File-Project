using System.IO;

static public class AuthorFunctions
{
    static public void Write_Author(Author s)
    {
        FileStream FS = new FileStream("Author.txt", FileMode.Append);
        StreamWriter SW = new StreamWriter(FS);
        char[] id = new char[5];
        char[] name = new char[20];
        char[] Email = new char[25];
        s.id.CopyTo(0, id, 0, s.id.Length);
        s.authorName.CopyTo(0, name, 0, s.authorName.Length);
        s.email.CopyTo(0, Email, 0, s.email.Length);
        SW.Write(id, 0, 5);
        SW.Write(name, 0, 20);
        SW.Write(Email, 0, 25);
        SW.Close();
    }
    static public string Searching_Author(string s)
    {
        FileStream fs = new FileStream("Author.txt", FileMode.Open);
        StreamReader sr = new StreamReader(fs);
        char[] record = new char[50];
        bool found = false;
        string str;
        string ID = "";
        while (sr.Peek() != -1)
        {
            sr.Read(record, 0, 50);
            str = new string(record);
            if (s.CompareTo(str.Substring(5, 20)) == 0)
            {
                found = true;
                 ID = str.Substring(0, length: 5);
                break;
            }
            
        }
        sr.Close();
        if (found == false)
        {
            return null;
        }
        else
        { 
            return int.Parse(ID).ToString();
        }

    }
    static public Author[] Author_read()
    {
        FileStream fs = new FileStream("Author.txt", FileMode.Open);
        StreamReader sr = new StreamReader(fs);
        char[] id = new char[5];
        char[] name = new char[20];
        char[] Email = new char[25];
        long size = fs.Length;
        bool empty=false;
        Author[] Record = new Author[size / 50];
        int i = 0;
        while (sr.Peek() != -1)
        {
            empty = true;
            sr.Read(id, 0, 5);
            sr.Read(name, 0, 20);
            sr.Read(Email, 0, 25);
            Record[i].id = int.Parse(new string(id)).ToString();
            Record[i].authorName = new string(name).Trim(' ', '\0');
            Record[i].email = new string(Email).Trim(' ', '\0');
            i++;
        }
        sr.Close();
        if (empty)
        {
            return Record;
        }
        else
        {
            return null;
        }
    }
    static public bool Author_Checker(Author A)
    {
        FileStream fs = new FileStream("Author.txt", FileMode.Open);
        StreamReader sr = new StreamReader(fs);
        char[] ID = new char[5];
        char[] notused = new char[45];
        long size = fs.Length;
        Author[] Authors = new Author[size / 50];
        bool found = false;
        string s;
        for(int i = 0; i < Authors.Length; i++)
        {
            sr.Read(ID, 0, 5);
            sr.Read(notused, 0, 45);
            s = new string(ID).Trim(' ','\0');
            if (A.id.ToString().CompareTo(s) == 0)
            {
                found = true;
                break;
            }
            
        }
        sr.Close();
        if (found)
        {
            return true;
        }
        else return false;

    }
}
