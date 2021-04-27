using System;
using ProductDataAccessLayer;
using ProductBusinessLogicLayer;

namespace ProductPresentatoinLayer
{
    class Program
    {

        static void Main(string[] args)
        {
            ProductLogic logic = new ProductLogic();
            do
            {
                Console.WriteLine("1 insert into product \n  2 insert into category \n 3 retrive data from category\n  4 retrive data from product \n 5 retrive products basedon id \n 6 update product price based on id \n 7 delete product based on id");
                Console.WriteLine("select your choice");
                
                int choice = int.Parse(Console.ReadLine());
                logic.Selectchoice(choice);




            } while (true);
        }
    }
}
