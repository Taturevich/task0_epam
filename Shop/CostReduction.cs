using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class CostReduction : Purchase
    {
        protected int discount;
        public CostReduction(string name, int month, int day, int price, int number, int discount)
        {
            this.symbol = 2;
            SetType("Cost_reduct");
            this.name = name;
            this.month = month;
            this.day = day;
            this.price = price;
            this.number = number;
            this.discount = discount;
        }

        public override void SetName(string name)
        {
            this.name = name;
        }

        public override string GetName()
        {
            return this.name;
        }

        public override void SetType(string type)
        {
            this.type = type;
        }

        public override string GetPurchaseType()
        {
            return this.type;
        }

        public override void SetMonth(int month)
        {
            this.month = month;
        }

        public override int GetMonth()
        {
            return this.month;
        }

        public override void SetDay(int day)
        {
            this.day = day;
        }

        public override int GetDay()
        {
            return this.day;
        }

        public override void SetPrice(int price)
        {
            this.price = price;
        }

        public override int GetPrice()
        {
            return this.price;
        }

        public override void SetNumber(int number)
        {
            this.number = number;
        }

        public override int GetNumber()
        {
            return this.number;
        }

        public  void SetDiscount(int discount)
        {
            this.discount = discount;
        }

        public  int GetDiscount()
        {
            return this.discount;
        }

        public override int GetSymbol()
        {
            return this.symbol;
        }

        /// <summary>
        /// Получение цены за всю партию товара
        /// </summary>
        /// <param name="Price"></param>
        /// <param name="Number"></param>
        /// <returns></returns>
        public override int GetTotalPrice(int Price, int Number)
        {
            return Convert.ToInt32(Price * Number*(1-Convert.ToDouble(discount)/100));
        }

        public override string ToString()
        {
            return String.Format("Name={0};Type={1};Month={2};Day={3};Price={4};Number={5};Total_price={6}", name, type, month, day, price, number, GetTotalPrice(price,number));
        }
    }
}
