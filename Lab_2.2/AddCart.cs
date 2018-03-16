using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2;
namespace Lab_2
{
   class AddCart
    {
         List<Cart> listCart = new List<Cart>();
        
        //Khi them album vào cart
        public void AddAlbumCart(Album album)
        {           
            Cart a = new Cart(album.AlbumID1,1,album.Price1,album.Price1);
            listCart.Add(a);
        }
        public List<Cart> ListCartA()
        {
            return listCart;
        }
        public bool RemoveAlbumCart(string idAlbum)
        {
            var album = from a in listCart where a.AlbumID1 == idAlbum select a;
            if(album.Count()==0)
                return false;                
            else
            {
                var cart = from a in listCart where a.AlbumID1 == idAlbum select a;
                Cart C = cart.ElementAt(0); 
                listCart.Remove(C);
                return true;
            }
        }
        // cập nhật giỏ Cartalbum và in ra màn hình
        public string OutputCart()
        {
            for(int i=0;i<listCart.Count;i++)
            {
                for (int j = listCart.Count - 1; j>0;j-- )
                {
                    if (listCart[i].AlbumID1 == listCart[j].AlbumID1 && i!=j)
                    {
                        
                        Cart a = new Cart(listCart[i].AlbumID1, listCart[i].Quantity1 + 1, listCart[i].Price1, listCart[i].Price1*(listCart[i].Quantity1 + 1));
                        listCart[i] = a;
                        listCart.Remove(listCart[j]);
                    }
                }
                    
            }
            string row = "Your cart:\n";
            row += "ID\tQuantity\t\t\t\tPrice\t\tAmount\n";
            for (int i = 0; i < listCart.Count;i++ )  
                row += listCart[i].AlbumID1 + "\t" + listCart[i].Quantity1 + "\t\t\t\t\t" + listCart[i].Price1 + "\t\t" + listCart[i].Amount1 + "\n";           
            row += "-------------------------------------------------------------------\n";
            //tong tien
            var sum = listCart.Select(c => c.Amount1).Sum();
            row += "TOTAL AMOUNT \t\t\t\t\t\t\t" + sum + "\n";
            return row;
        }
       public double Tongtien()
        {
            //tong tien
            var tongtien = listCart.Select(c => c.Amount1).Sum();
            return tongtien;
        }
    }
}
