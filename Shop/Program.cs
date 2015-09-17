using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Purchase> shoppinglist = new List<Purchase>();

            Purchase notebook = new Purchase("Notebook", 10, 10, 5000, 5);
            shoppinglist.Add(notebook);

            Bonus bag = new Bonus("Bag", 4, 23, 6000, 3, 10000);
            Bonus hat = new Bonus("Hat", 5, 11, 6000, 3, 5700);
            Bonus wine = new Bonus("Wine", 6, 7, 12000, 2, 9320);
            shoppinglist.Add(bag);
            shoppinglist.Add(hat);
            shoppinglist.Add(wine);

            CostReduction shirt = new CostReduction("Shirt", 1, 1, 200, 10, 10);
            CostReduction hoody = new CostReduction("Hoody", 8, 17, 543, 5, 15);
            CostReduction jeans = new CostReduction("Jeans", 4, 20, 1000, 4, 95);
            shoppinglist.Add(shirt);
            shoppinglist.Add(hoody);
            shoppinglist.Add(jeans);

            TransportDiscount water = new TransportDiscount("Water", 12, 7, 900, 2, 300);
            TransportDiscount milk = new TransportDiscount("Milk", 5, 17, 2010, 3, 1243);
            TransportDiscount bread = new TransportDiscount("Bread", 4, 11, 1000, 1, 999);
            shoppinglist.Add(water);
            shoppinglist.Add(milk);
            shoppinglist.Add(bread);

            Purchase.ShowResults("Starting table:", shoppinglist);
            shoppinglist.Sort();
            Purchase.ShowResults("Sort by days:", shoppinglist);

            if (Purchase.SearchDate(shoppinglist))
                Purchase.ShowResults("The 10 day of the month have been committed purchases");
            else
                Purchase.ShowResults("No purchases of 10");

            shoppinglist = Purchase.SortByType(shoppinglist);
            Purchase.ShowResults("Sort by category:", shoppinglist);
            
            Console.ReadKey();
        }
    }
}
