using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._2
{
    class Xuly
    {
        AddAlbum addalbum = new AddAlbum();
        AddUser addUser = new AddUser();
        public string Output0()
        {
            string row = "<==================================================================================================>\n";
            row += "Music store system\n";
            row += "Author: SE01234, Nguyen Tuan Anh\n";
            row += "\n";
            row += "MENU:\n";
            row += "1.	Add an album to your cart\n";
            row += "2.	Remove an album from your cart\n";
            row += "3.	Check out\n";
            row += "4.	Exit\n";
            row += "Please enter 1, 2, 3, or 4:";
            return row;
        }
        public void Check(int id)
        {
            addalbum.Input();           
            if(id==1)
            {
                Console.WriteLine(addalbum.Output1());
                addalbum.checkAlbum();
            }
            if(id==2)
            {
                addalbum.checkCart();               
            }
            if(id==3)
            {
                Console.WriteLine("Total amount (USD): " + addalbum.Tongtien());
                Console.WriteLine(addUser.checkUser3());
                Console.Write("Save it (y/n)?:  ");
                string check = Console.ReadLine();
                if(check =="y" || check =="Y")
                {
                    Console.WriteLine(addalbum.OutputDetail());
                }
            }
        }
    }
}
