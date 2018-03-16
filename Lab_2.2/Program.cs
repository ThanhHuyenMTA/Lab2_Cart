using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._2
{
    class Program
    {

        static void Main(string[] args)
        {

            Xuly test = new Xuly();
            Nhap:
            Console.WriteLine(test.Output0());
            int id = Int32.Parse(Console.ReadLine());
            test.Check(id);
            goto Nhap;
            Console.ReadLine();
           
        }
        
    }
}
