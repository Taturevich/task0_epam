using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Purchase : IComparable
    {
        protected int symbol = 1;
        protected string name;
        protected string type;
        protected int month;
        protected int day;
        protected int price;
        protected int number;

        public Purchase() 
        {
 
        }
        public Purchase(string name, int month, int day, int price, int number)
        {
            SetType("Common");
            this.name = name;
            this.month = month;
            this.day = day;
            this.price = price;
            this.number = number;
        }

        public virtual void SetName(string name)
        {
            this.name = name;
        }

        public virtual string GetName()
        {
            return this.name;
        }

        public virtual void SetType(string type)
        {
            this.type = type;
        }

        public virtual string GetPurchaseType()
        {
            return this.type;
        }

        public virtual void SetMonth(int month)
        {
            this.month = month;
        }

        public virtual int GetMonth()
        {
            return this.month;
        }

        public virtual void SetDay(int day)
        {
            this.day = day;
        }

        public virtual int GetDay()
        {
            return this.day;
        }

        public virtual void SetPrice(int price)
        {
            this.price = price;
        }

        public virtual int GetPrice()
        {
            return this.price;
        }

        public virtual void SetNumber(int number)
        {
            this.number = number;
        }

        public virtual int GetNumber()
        {
            return this.number;
        }

        public virtual int GetSymbol()
        {
            return this.symbol;
        }

        /// <summary>
        /// Получение цены за всю партию товара
        /// </summary>
        /// <param name="Price"></param>
        /// <param name="Number"></param>
        /// <returns></returns>
        public virtual int GetTotalPrice(int Price, int Number)
        {
            return Price * Number;
        }

        public static void ShowResults(string Message)
        {
            Console.WriteLine(Message+"\r\n");
            System.IO.File.AppendAllText(@"Result.txt", Message+"\r\n");
        }

        /// <summary>
        /// Вывод результатов на консоль и в файл
        /// </summary>
        /// <param name="Message"></param>
        /// <param name="ResultsList"></param>
        public static void ShowResults(string Message, List<Purchase> ResultsList)
        {
            StringBuilder Text = new StringBuilder();
            Text.Append(Message + "\r\n");
            for (int i = 0; i < ResultsList.Count; i++)
                Text.Append(ResultsList[i] + "\r\n");
            Console.WriteLine(Text);
            System.IO.File.AppendAllText(@"Result.txt", Text.ToString());
        }

        /// <summary>
        /// Поиск наличия покупок 10 числа
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool SearchDate(List<Purchase> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].day==10)
                    return true;
            }
                return false;
        }


        /// <summary>
        /// Сортировка по категориям
        /// </summary>
        /// <param name="list"></param>
        public static List<Purchase> SortByType(List<Purchase> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j].symbol < list[i].symbol)
                    {
                        var temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            return list;
        }
        /// <summary>
        /// Сортировка по дням
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Purchase CommonPurchase = obj as Purchase;
            if (CommonPurchase != null)
                return this.day.CompareTo(CommonPurchase.day);
            else
                throw new ArgumentException("Object is not a Purchase");
        }

        public override string ToString()
        {
            return String.Format("Name={0};Type={1};Month={2};Day={3};Price={4};Number={5};Total_price={6}", name, type, month, day, price, number, GetTotalPrice(price,number));
        }

        
    }
}
