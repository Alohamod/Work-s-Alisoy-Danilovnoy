namespace Lab10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string fileName = "example.txt";
            string fullPath = Path.Combine(folderPath, fileName);
            File.Create(fullPath).Close();
            File.WriteAllText(fullPath, "Hello");
            File.AppendAllText(fullPath, "world");
            string[] joi = new string[] {"rrf","rfr","wqwer"};
            File.WriteAllLines(fullPath, joi);
            string con = File.ReadAllText(fullPath);
            string[] con_ar = File.ReadAllLines(fullPath);
            Console.WriteLine(con);
            Console.WriteLine(string.Join("\n", con_ar));

            string folderPath1 = Path.Combine(folderPath, "EXAMPl");
            string folderPath2 = Path.Combine(folderPath1, "anothexamp");
            if (!Directory.Exists(folderPath1))
            {
                Directory.CreateDirectory(folderPath1);
                if (!File.Exists(folderPath2))
                    {
                    File.Create(folderPath2).Close(); 
                }
            }
            string ext = "txt";
            string folderPath3 = Path.GetDirectoryName(folderPath2);
            string fileName1 = Path.GetFileName(folderPath2);
            Console.Write(fileName1);
            

        }
    }
}