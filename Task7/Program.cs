using System.IO;
using System.Text;
using System.Globalization;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputText = File.ReadAllText("input.txt", Encoding.Default);
            string OutputText = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(InputText);
            File.WriteAllText("output.txt", OutputText, Encoding.GetEncoding("utf-8"));
        }
    }
}
