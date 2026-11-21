using System.Runtime.InteropServices;

namespace s4_assingment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //double[] prices =  {25.5,40.0,33.75};
            //Console.WriteLine(prices[1]);
            #endregion
            #region Q2
            //int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
            //Console.WriteLine($"the number of copies on shelf 1, slot 0: {shelfCopies[1, 0]}");
            #endregion
            #region the rest of Q3
            //PrintWelcomeMessage();
            #endregion
            #region The rest of Q4
            //PrintBookTitle("Clean Code");
            #endregion
            #region rest of Q5
            //int pages = 400;
            //AddBounsPages(pages);
            //Console.WriteLine(pages);//still 400 because it was passed by value doesn't affect the original var
            #endregion
            #region rest of Q6
            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);//the resault is 20.5 because it was passed by value refrence type
            #endregion
            #region rest of 7
            //int pages = 400;
            //AddBounsPagesByRef(ref pages);
            //Console.WriteLine(pages);//become 450 because it is pass by ref value type
            #endregion
            #region rest of 8
            //double[] prices = { 25.5, 40.0 };
            //ReplaceArray(ref prices);
            //Console.WriteLine(prices.Length);
            #endregion
            #region rest of 9
            //string title = "Clean Code";
            //bool res = TryGetPrice(title, out double price);
            //if (res)
            //{
            //    Console.WriteLine($"The price is {price}");
            //}
            //else
            //{
            //    Console.WriteLine("NO book avaiable");
            //}
            #endregion
            #region rest of 10
            //PrintBookInfo("c#");
            //PrintBookInfo("c++", 500);
            #endregion
            #region rest of 11
            //PrintBookInfo(pages:300, title:"C#");
            #endregion
            #region rest of 12
            //PrintAllTitles("c#","c++","java");
            #endregion
        }
        #region Q3
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        #endregion
        #region Q4
        public static void PrintBookTitle(string title)
        {
            Console.WriteLine($"Book title: {title}");
        }
        #endregion
        #region Q5
        //public static void AddBounsPages(int pages)
        //{
        //    pages += 50;
        //}
        #endregion
        #region Q6
        public static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5; 
        }
        #endregion
        #region Q7
        public static void AddBounsPagesByRef(ref int pages)
        {
            pages += 50;
        }
        #endregion
        #region Q8
        public static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }
        #endregion
        #region Q9
        public static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
        }
        #endregion
        #region Q10
        //public static void PrintBookInfo(string title, int pages = 300)
        //{
        //    Console.WriteLine($"Book: {title}, Pages: {pages}");
        //}
        #endregion
        #region Q11
        public static void PrintBookInfo(string title = "c#", int pages = 300)
        {
            Console.WriteLine($"Book: {title}, Pages: {pages}");
        }

        #endregion
        #region Q12
        public static void PrintAllTitles(params string[] titles)
        {
            foreach (string title in titles)
            {
                Console.WriteLine(title);
            }
        }
        #endregion
    }
}
