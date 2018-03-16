using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
   public class AddUser
    {
        AddCart a = new AddCart();
        List<Orderdetail> listOrderDe ;
        public string checkUser3()
        {
           string row = "Enter first name: Anh\n";
            row += "Enter last name: Nguyen Van\n";
            row += "Enter address:	No 5, Lo Duc\n";
            row += "Enter city: Hanoi\n";
            row += "Enter state: Hai Ba Trung\n";
            row += "Enter country: Vietnam\n";
            row += "Enter phone number: 09 3456 5677\n";
            row += "Enter email address:  AnhNguyen@fpt.edu.vn\n";
            return row;
        }

        public List<Orderdetail> CapnhhatOrder(List<Cart> listCart)
        {
            listOrderDe =  new List<Orderdetail>();

            Order order = new Order("SE01234", DateTime.Now, "Anh", "Nguyen Van", "No 5, Lo Duc", "Hanoi", "Hai Ba Trung", "Vietnam", "09 3456 5677", "AnhNguyen@fpt.edu.vn",a.Tongtien());           
            for(int i=0;i<listCart.Count;i++)
            {
                
                Orderdetail orderDetail = new Orderdetail("CT"+i, order.OrderID, listCart[i].AlbumID1, listCart[i].Quantity1);
                listOrderDe.Add(orderDetail);
            }
            return listOrderDe;
        }
       
    }
}
