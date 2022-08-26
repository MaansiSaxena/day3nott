using System;

namespace ecommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string res = Console.ReadLine();

            order productname = new order();

            if (res == "Y")
            {
                switch (n)
                {
                    case 1:
                        productname.orderdetails();
                        goto case 2;
                    case 2:
                        productname.showorder();
                        break;
                    case 3:
                        productname.customerdetails();
                        goto case 4;
                    case 4:
                        productname.showcustomer();
                        goto case 2;
                }
            }
            else
            {
                Console.WriteLine("you have exited the switch");
                Console.ReadLine();
            }

        }
    }
    public class order : Iorder,Icustomer
    {
        Icustomer[] pl = new Icustomer[2];

        public void orderdetails()
        {
            Iorder[] or = new Iorder[2];
            for (int i = 0; i < 2; i++)
            {
                Console.Write("enter the order id: ");
                or[i].id = int.Parse(Console.ReadLine());
                Console.Write("enter the order Name: ");
                or[i].Name = Console.ReadLine();              
                Console.Write("enter the product name: ");
                or[i].productname = Console.ReadLine();
                Console.Write("enter the product id: ");
                or[i].pid = Console.ReadLine();
                Console.Write("enter the price: ");
                or[i].price = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void customerdetails()
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.Write("enter the order id: "); pl[i].Id = int.Parse(Console.ReadLine());
                Console.Write("enter the order Name: "); pl[i].Name = Console.ReadLine();
                Console.Write("enter the Player Gender: "); pl[i].Gender = Console.ReadLine();
            }
        }

        public void showorder()
        {
            customer[] cu = new customer[2];
            for (int i = 0; i <= 2; i++)
            {
                Console.Write("enter the order id: " + cu[i].Id);
                Console.Write("enter the order Name: " + cu[i].Name);
                Console.Write("enter the pid: " + cu[i].pid);
                Console.Write("enter the product name: " + cu[i].productname);
                Console.Write("enter the price: " + cu[i].price);
            }
        }

        public void showcustomer()
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.Write("enter the customer id: " + pl[i].Id);
                Console.Write("enter the customer Name: " + pl[i].Name);
                Console.Write("enter the customer Gender: " + pl[i].Gender);
                Console.Write("enter the customer Mobile: " + pl[i].Mobile);
            }
        }
    }
}