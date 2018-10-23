using System;
using System.Collections.Generic;

namespace Constructors
{
    public class Customer
    {
        public int ID;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }
        public Customer(int ID)
            : this()
        {
            this.ID = ID;
        }
        public Customer(int ID, string name)
            : this(ID)
        {
            this.ID = ID;
            this.Name = name;
        }
    }
}
