namespace Second
{
    internal class Program 
    {
        static void first_ep()
        {
            int a = 2;
            Console.WriteLine(a);
            //comments
            /*
             *this 
             *is
             *comment
             */
            Console.WriteLine("\tBros");
            
        }

        static void second_ep()
        {
            int x; // declaration
            x = 50; // init

            int y = 30; // both

            int z = x + y; //declaration with sum
            Console.WriteLine("Your bruh count is: " + z);
             
            double cm = 6.8; //using floating point.
            Console.WriteLine("Sadge only " + cm + " cm");

            bool prom = true; //Bollean values only True/False that is 1 or 0
            Console.WriteLine("Would you like to go to with me? " + prom);

            char symbol = '@'; // character declaration 
            Console.WriteLine("Symbol for today is " + symbol);

            String name = "Michael"; // String it's a character array
            Console.WriteLine("My name is " + name);

            String username = symbol + name;
            Console.WriteLine("Your username is " + username);

        }

        static void third_ep()
        {
            const double pi = 3.14159;

            /* pi = 69;
             * you can't do above line cause keyword "const" is preventing of any changes
             */

            Console.WriteLine("You can't change the PI = " + pi);


        }

        static void fourth_ep()
        {
            // in short, changing data type of variable of your choice
            // for example you can change Double into Int, the result would be getting rid of everyting after decimal point

            double a = 3.14;
            int b = Convert.ToInt32(a);
            Console.WriteLine("Int value: " + b + "Data type: " + b.GetType());
            Console.WriteLine("Double value: " + a + "Data type: " + a.GetType());
            Console.WriteLine();

            int c = 123;
            double d = Convert.ToDouble(c);
            Console.WriteLine("Int value: " + c + "Data type: " + c.GetType());
            Console.WriteLine("Double value: " + d + "Data type: " + d.GetType());
            Console.WriteLine();

            int e = 69;
            string f = Convert.ToString(e);
            Console.WriteLine("Int value: " + e + "Data type: " + e.GetType());
            Console.WriteLine("String value: " + f + "Data type: " + f.GetType());
            Console.WriteLine();

            string g = "$";
            char h = Convert.ToChar(g);
            Console.WriteLine("String value: " + g + "Data type: " + g.GetType());
            Console.WriteLine("char value: " + h + "Data type: " + h.GetType());
            Console.WriteLine();

            string i = "true";
            bool j = Convert.ToBoolean(i);
            Console.WriteLine("String value: " + i + "Data type: " + i.GetType());
            Console.WriteLine("Boolean value: " + j + "Data type: " + j.GetType());
            Console.WriteLine();


        }

        static void fifth_ep()
        {

        }
        static void Main(string[] args)
        {
            //---------------------------------------------------------------------------------------------------------------
            // calling a functions
            first_ep(); //very basics
            Console.WriteLine("\n\n1st part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            second_ep(); //variables
            Console.WriteLine("\n\n2nd part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            third_ep(); //constants
            Console.WriteLine("\n\n3rd part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            fourth_ep(); //type casting
            Console.WriteLine("\n\n4th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            fifth_ep(); //user input
            Console.WriteLine("\n\ntth part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
        }
    }
}