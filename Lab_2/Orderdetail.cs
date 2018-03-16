using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
   public class Orderdetail
    {
        private string orderdetailID;


        public string OrderdetailID
        {
            get { return orderdetailID; }
            set { orderdetailID = value; }
        }
        private string orderID;

        public string OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }
        private string albumID;

        public string AlbumID
        {
            get { return albumID; }
            set { albumID = value; }
        }
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public Orderdetail() { }
        public Orderdetail(string orderdetailID,string orderID,string albumID,int quantity )
        {
            this.orderdetailID = orderdetailID;
            this.orderID = orderID;
            this.albumID =albumID;
            this.quantity = quantity;
        }
    }
}
