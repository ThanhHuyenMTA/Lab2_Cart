using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
  public  class Order
    {
        private string orderID;

        public string OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }
        private DateTime orderDate;

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }
        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        //tổng tiền
        private double totalMount;

        public double TotalMount
        {
            get { return totalMount; }
            set { totalMount = value; }
        }

        public Order() { }
        public Order(string orderID,DateTime orderdate,string firstName,string lastName,string address,
            string city,string state,string country,string phone,string email,double totalAmount)
        {
            this.orderID = orderID;
            this.orderDate = orderdate;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.country = country;
            this.phone = phone;
            this.email = email;
            this.TotalMount = totalMount;
        }
    }
}
