using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Bonus : Purchase
    {
        protected int bonusprice;

        public Bonus(string name, int month, int day, int price, int number, int bonusprice)
        {
            this.symbol = 4;
            SetType("Bonus");
            this.name = name;
            this.month = month;
            this.day = day;
            this.price = price;
            this.number = number;
            this.bonusprice = bonusprice;
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

        public void SetBonusPrice(int bonusprice)
        {
            this.bonusprice = bonusprice;
        }

        public int GetBonusPrice()
        {
            return this.bonusprice;
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
            return Price * Number - bonusprice;
        }

        public override string ToString()
        {
            return String.Format("Name={0};Type={1};Month={2};Day={3};Price={4};Number={5};Total_price={6}", name, type, month, day, price, number, GetTotalPrice(price,number));
        }
    }
}
