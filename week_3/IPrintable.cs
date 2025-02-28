using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3
{
    interface IPrintable
    {
        void Print();
    }

    interface ISerializable
    {
        void SaveToFile(string filePath);
    }

    class Report : IPrintable, ISerializable
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public Report(string title, string content)
        {
            Title = title;
            Content = content;
        }

        public void Print()
        {
            Console.WriteLine($"Report Title: {Title}");
            Console.WriteLine($"Content: {Content}");
        }

        public void SaveToFile(string filePath)
        {
            File.WriteAllText(filePath, $"Report Title: {Title}\nContent: {Content}");
            Console.WriteLine($"Report saved to {filePath}");
        }
    }

    //class Program9
    //{
    //    static void Main()
    //    {
    //        Report report = new Report("Monthly Sales", "This report contains sales data for the month.");

    //        Console.WriteLine("Printing Report:");
    //        report.Print();

    //        string filePath = "report.txt";
    //        report.SaveToFile(filePath);
    //    }
    //}
}
