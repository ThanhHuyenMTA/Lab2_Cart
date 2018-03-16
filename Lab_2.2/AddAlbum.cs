using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2;

namespace Lab_2
{
    
    class AddAlbum
    {     
        Album album = new Album();
        Album[] listAlbum = new Album[3];
        AddCart addCart = new AddCart();
        AddUser addUser = new AddUser();
        public void Input()
        {
            listAlbum[0] = new Album("386", "Rock", "For Those About To Rock We Salute You", 8.99);
            listAlbum[1] = new Album("387","Rock","Let There Be Rock",8.99);
            listAlbum[2] = new Album("388", "Rock", "Greatest Hits",8.99);
        }
       
        //trả về list album ban đầu 
        public string Output1()
        {          
            string row1 = "List of all albums\n";
            row1 += "ID\tGenre\tTitle							        Price\n";
            for(int i=0;i<listAlbum.Length;i++){
                row1 += "" + listAlbum[i].AlbumID1 + "\t" + listAlbum[i].Genreid1 + "\t" + listAlbum[i].Title1 + 
                    "\t\t\t" + listAlbum[i].Price1 + "\n";   
            }
            return row1;
        }
        public void checkAlbum()
        {
           
            NhapIDAlbum:
            Console.Write("Enter album ID: ");            
            string idAlbum = Console.ReadLine();
            var albumA = (from a in listAlbum where a.AlbumID1 == idAlbum select a);
            
            if(albumA.Count()!=0){
                    Album B = albumA.ElementAt(0); //quy về Album
                    addCart.AddAlbumCart(B);
                    Console.WriteLine(addCart.OutputCart());
            }else
            {                
                Console.WriteLine("It doesn’t exist!");
                goto NhapIDAlbum;
            }               
        }

        public void checkCart()
        {
            Console.WriteLine(addCart.OutputCart());
            NhapIDAlbum:
            Console.Write("Enter album ID: ");
            string idAlbum = Console.ReadLine();
            if(addCart.RemoveAlbumCart(idAlbum)==false)
            {
                Console.WriteLine("It doesn’t exist!");
                goto NhapIDAlbum;
            }else{
                Console.WriteLine(addCart.OutputCart());
            }                       
        }
        public double Tongtien()
        {
            List<Cart> listC = addCart.ListCartA();
            //tong tien
            var tongtien = listC.Select(c => c.Amount1).Sum();
            return tongtien;
        }
        public string OutputDetail()
        {
            List<Orderdetail> list = addUser.CapnhhatOrder(addCart.ListCartA());
            string row = "\torderdetailID \torderID \t albumID \t quantity\n";
            for (int i = 0; i < list.Count; i++)
            {
                row +="\t"+ list[i].OrderdetailID + "\t\t" + list[i].OrderID + "\t\t " + list[i].AlbumID + "\t\t" + list[i].Quantity + "\n";
            }
            return row;
        }
    }
}
