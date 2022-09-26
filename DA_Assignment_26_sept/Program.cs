namespace DA_Assignment_26_sept
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaraction
            string str = @"C:\Users\anand.kumar\OneDrive - Entain Group\Documents\DA_Assignment\append_some_text.txt";
            StreamWriter sw=File.AppendText(str);//open stream writer to append file.
            //accept comment from user in a string variable
            Console.WriteLine("Plese enter your text: ");
            string str2=Console.ReadLine();
            sw.WriteLine(str2);
            sw.Close();
        }
    }
}