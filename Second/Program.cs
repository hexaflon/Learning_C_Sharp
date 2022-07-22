namespace Second
{
    internal class Program
    {
        static void ep_1() //very basics
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

        static void ep_2() //variables
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

        static void ep_3() //constants
        {
            const double pi = 3.14159;

            /* pi = 69;
             * you can't do above line cause keyword "const" is preventing of any changes
             */

            Console.WriteLine("You can't change the PI = " + pi);


        }

        static void ep_4() //type casting
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

        static void ep_5() //user input
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            Console.WriteLine("What's your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are " + age);

        }

        static void ep_6() //Arithmetic operators
        {
            int friends = 5;
            friends++;
            friends += 3;

            friends--;

            friends *= 2;
            friends /= 2;

            int remainder = friends % 3;

            Console.WriteLine("Friends: " + remainder);
        }

        static void ep_7() //Math class
        {
            double x = 4;
            double a = Math.Pow(x, 2); // Power, your number to desired powers
            Console.WriteLine(a);

            double b = Math.Sqrt(x); // Square root of a number
            Console.WriteLine(b);

            x *= -1;
            double c = Math.Abs(x); // Absolute value 
            Console.WriteLine(c);

            a = 3.14;
            b = 3.70;

            Console.WriteLine(Math.Ceiling(a)); // Round to highest possible math decimal
            Console.WriteLine(Math.Floor(b)); // ROund to lowest possible math decimal

        }

        static void ep_8() //Random numbers
        {
            Random random = new Random(); 
            int num = random.Next(1, 7);
            Console.WriteLine(num);

            double num2 = random.NextDouble();
            Console.WriteLine(num2);



        }

        static void ep_9() //Hypotenuse calculator
        {
            Console.WriteLine("Enter side A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt(a * a + b * b);
            Console.WriteLine("Hypotenuse is " + c);

        }

        static void ep_10() //String methods
        {

        }

        static void show_ep1_5(){
            //---------------------------------------------------------------------------------------------------------------
            // calling a functions
            ep_1(); //very basics
            Console.WriteLine("\n\n1st part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_2(); //variables
            Console.WriteLine("\n\n2nd part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_3(); //constants
            Console.WriteLine("\n\n3rd part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_4(); //type casting
            Console.WriteLine("\n\n4th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_5(); //user input
            Console.WriteLine("\n\n5th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
        }

        static void show_ep6_10()
        {
            //---------------------------------------------------------------------------------------------------------------
            ep_6(); //Arithmetic operators
            Console.WriteLine("\n\n6th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_7(); //Math class
            Console.WriteLine("\n\n7th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_8(); //Random numbers
            Console.WriteLine("\n\n8th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_9(); //Hypotenuse calculator
            Console.WriteLine("\n\n9th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_10(); //String methods
            Console.WriteLine("\n\n9th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
        }
        static void Main(string[] args)
        {
            //show_ep1_5();
            show_ep6_10();
            //testing git

        }
    }
}