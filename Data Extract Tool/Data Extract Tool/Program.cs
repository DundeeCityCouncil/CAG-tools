using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Data_Extract_Tool
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please specify location of CSV File to Split");
            string csv_file_path = Console.ReadLine();
            Console.WriteLine("Please specify the desired output location of generated files");
            string output_path = Console.ReadLine();
            var reader = new StreamReader(File.OpenRead(csv_file_path));
            string output_path_csv15 = output_path + "\\csv15.csv";
            string output_path_csv24 = output_path + "\\csv24.csv";
            StreamWriter file1 = new StreamWriter(output_path_csv15);
            StreamWriter file2 = new StreamWriter(output_path_csv24);

            int count1 = 0;
            int count2 = 0;
            while (!reader.EndOfStream)
            {


                var line = reader.ReadLine();
                
                var values = line.Split(',');
                var flag = values[0];
                if (flag == "15")
                {
                    count1 = count1 + 1;
                    //csv15.AppendLine(line);
                    Console.WriteLine("15 CSV Count:" + count1);
                    file1.WriteLine(line);
                    
                }

                
                else if (flag == "24")
                {
                    count2 = count2 + 1;
                    //csv24.AppendLine(line);
                    Console.WriteLine("24 CSV Count:" + count2);
                    file2.WriteLine(line);
                    
                }

                else { }

            }

            Console.WriteLine("CSV Export Finished, closing...");
            Console.ReadLine();
        }
    }
}
