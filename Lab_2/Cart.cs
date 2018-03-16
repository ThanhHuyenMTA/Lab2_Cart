using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
   public class Cart
    {
        private string AlbumID;

        public string AlbumID1
        {
            get { return AlbumID; }
            set { AlbumID = value; }
        }
        private int Quantity;

        public int Quantity1
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
        private double Price;

        public double Price1
        {
            get { return Price; }
            set { Price = value; }
        }
        private double Amount;

        public double Amount1
        {
            get { return Amount; }
            set { Amount = value; }
        }
        public Cart() { }
        public Cart(string AlbumID, int quantity, double price)
        {
            this.AlbumID = AlbumID;
            this.Quantity = quantity;
            this.Price = price;
        }
        public Cart(string AlbumID,int quantity,double price,double amount)
        {
            this.AlbumID = AlbumID;
            this.Quantity = quantity;
            this.Price = price;
            this.Amount = amount;
        }
    }
}
