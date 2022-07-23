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
            string fullname = "Bro Code";
            string phonenumber = "123-456-7890";

            fullname = fullname.ToUpper();
            Console.WriteLine(fullname);

            phonenumber = phonenumber.Replace("-", "/");
            Console.WriteLine(phonenumber);

            String username = fullname.Insert(0, "@");
            Console.WriteLine(username);


            Console.WriteLine(fullname.Length);

            string firstname = fullname.Substring(0, 3);
            Console.WriteLine(firstname);

            string lastname = fullname.Substring(4, 4);
            Console.WriteLine(lastname);



        }

        static void ep_11() //if statements
        {
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 100) Console.WriteLine("Too old");
            else if (age >= 18) Console.WriteLine("Signed up!");
            else if (age < 0) Console.WriteLine("Wrong age");
            else Console.WriteLine("You are too young");

            Console.WriteLine("Enter your name: ");
            String name = Console.ReadLine();

            if (name == "") Console.WriteLine("You did not enter your name");
            else Console.WriteLine("Hello " + name);

        }

        static void ep_12() //switches
        {
            Console.WriteLine("What day is it? ");
            String day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                    {
                        Console.WriteLine($"It's {day}");
                        break;
                    }
                case "Tuesday":
                    {
                        Console.WriteLine($"It's {day}");
                        break;
                    }
                case "Wednesday":
                    {
                        Console.WriteLine($"It's {day}");
                        break;
                    }
                case "Thursday":
                    {
                        Console.WriteLine($"It's {day}");
                        break;
                    }
                case "Friday":
                    {
                        Console.WriteLine($"It's {day}");
                        break;
                    }
                case "Saturday":
                    {
                        Console.WriteLine($"It's {day}");
                        break;
                    }
                case "Sunday":
                    {
                        Console.WriteLine($"It's {day}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That's not a day");
                        break;
                    }
            }
        }

        static void ep_13() //logical operators
        {
            Console.WriteLine("What's the temperature ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            if (temperature >= 10 && temperature <= 25) Console.WriteLine("It's ok outside");
            else if (temperature > 25) Console.WriteLine("It's too hot outside");
            else Console.WriteLine("It's too cold outside");

            if (temperature <= -50 || temperature >= 50) Console.WriteLine("Don't do it to yourself");

        }

        static void ep_14() //while loops
        {
            Console.WriteLine("Enter your name: ");
            String name = Console.ReadLine();

            while (name == "")
            {
                Console.WriteLine("Enter your name: ");
                name = Console.ReadLine();
            }

        }

        static void ep_15() //for loops
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * i);
            }
        }

        static void ep_16() //nested loops
        {
            Console.WriteLine("How many rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many columns?: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What symbol to build your rectangle: ");
            string symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

        }

        static void ep_17() //number guessing game
        {
            Random random = new Random();
            int guess = random.Next(1, 101);
            int number, tries = 0;
            while (true)
            {
                Console.WriteLine("Guess a number between 1 and 100");
                number = Convert.ToInt32(Console.ReadLine());
                tries++;
                if (guess == number) break;
                if (number > guess) Console.WriteLine("You guessed too high! ");
                if (number < guess) Console.WriteLine("You guessed too low! ");

            }
            Console.WriteLine("Congrats, you won!");
            Console.WriteLine($"It took you: {tries} tries"); //String formating using $ symbol before "", similiar to fstrings in python
        }

        static void ep_18() //rock paper scissors game
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;

            while (playAgain)
            {
                player = "";
                computer = "";
                while (player != "rock" && player != "paper" && player != "scissors")
                {
                    Console.Write("Enter ROCK, PAPER, SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToLower();
                }

                switch (random.Next(1, 4))
                {
                    case 1:
                        {
                            computer = "rock";
                            break;
                        }
                    case 2:
                        {
                            computer = "paper";
                            break;
                        }
                    case 3:
                        {
                            computer = "scissors";
                            break;
                        }
                }
                Console.WriteLine($"Player: {player}");
                Console.WriteLine($"Computer: {computer}");

                if ((player == "rock" && computer == "scissors") || (player == "paper" && computer == "rock") || (player == "scissors" && computer == "paper"))
                    Console.WriteLine("You win!");
                else if (player == computer) Console.WriteLine("Draw!");
                else Console.WriteLine("You lost!");
                Console.WriteLine("Do you want to play again?(Y/N)");
                player = Console.ReadLine();
                player = player.ToLower();
                if (player == "n") playAgain = false;
                Console.Clear();
            }

        }

        static void ep_19() // calculator
        {
            double a = 0, b = 0, result = 0;
            do
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("--------------------------------");

                Console.WriteLine("Enter number 1: ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter number 2: ");
                b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What do you want to do?");
                Console.WriteLine("+ : Add");
                Console.WriteLine("- : Substrtact");
                Console.WriteLine("* : Multiply");
                Console.WriteLine("/ : Divide");
                Console.WriteLine("Your option: ");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "+":
                        {
                            result = a + b;
                            Console.WriteLine($"Result of {a} {operation} {b} = {result}");
                            break;
                        }
                    case "-":
                        {
                            result = a - b;
                            Console.WriteLine($"Result of {a} {operation} {b} = {result}");
                            break;
                        }
                    case "*":
                        {
                            result = a * b;
                            Console.WriteLine($"Result of {a} {operation} {b} = {result}");
                            break;
                        }
                    case "/":
                        {
                            result = a / b;
                            Console.WriteLine($"Result of {a} {operation} {b} = {result}");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You chose the wrong option");
                            break;
                        }
                }
                Console.WriteLine("Do you want to use calculator again?(Y/N)");
                operation = Console.ReadLine();
                operation = operation.ToLower();
                if (operation == "n") break;
                Console.Clear();
            } while (true);



        }

        static void ep_20_and_21() // arrays and foreach loop
        {
            String[] cars = { "BMW", "Mustang", "Corvette" };

            for(int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"Car in {i + 1} position is {cars[i]}");
            }

            foreach(String car in cars)
            {
                Console.WriteLine($"Car is {car}");
            }

        }

        static void ep_22() //methods
        {
            String name = "Juan";
            sing_HB(name);

        }
        static void sing_HB(String name) //method used in ep_22
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine($"Happy birthday dear {name}!");
            Console.WriteLine("Happy birthday to you!");

        }

        static void ep_23() // return keyword
        {
            int j = num_in_ep_23();
            Console.WriteLine($"You passed a {j} into other method");
        }
        static int num_in_ep_23() //method used in ep_23
        {
            Console.WriteLine("Please type an Integer: ");
            int yep = Convert.ToInt32(Console.ReadLine());
            return yep;
        }

        static void ep_24() //method overload
        {
            double total = multiply(2, 4);
            Console.WriteLine(total);
            total = multiply(2, 4, 6);
            Console.WriteLine(total);

        }
        static double multiply(double a, double b)//method used in ep_24
        {
            return a * b;
        }
        static double multiply(double a, double b, double c)//method used in ep_24
        {
            return a * b * c;
        }

        static void ep_25() // params keyword
        {
            //params are used to pass multiple arguments to a method by passing them into the array
            double total = checkout(2, 4, 15.5, 39.232);
            Console.WriteLine(total);
        }

        static double checkout(params double[] a)
        {
            double sum = 0;
            foreach(double price in a)
            {
                sum += price;
            }
            return sum;
        }

        static void ep_26() //exception handling
        {
            int a, b, result;

            try
            {
                Console.WriteLine("Enter number 1: ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number 2: ");
                b = Convert.ToInt32(Console.ReadLine());

                result = a / b;

                Console.WriteLine(result);

            }
            catch(FormatException e)
            {
                Console.WriteLine("Please type a number!");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by 0!");
            }
            finally //Will always execute no matter if exception occured or no
            {
                Console.WriteLine("yep");
            }
        }

        static void ep_27() //conditional operator
        {
            double temperature = 15;
            string message;

            message = (temperature >= 20) ? "It's hot" : "It's cold";
            Console.WriteLine(message);

        }

        static void ep_28() //string interpolation
        {
            string name = "Michael";
            string lastname = "YEP";
            int age = 23;
            Console.WriteLine($"Hi, I am {name} {lastname} {age}, years old");
        }

        static void ep_29() //multidimensional arrays
        {
            String[] ford = { "Mustang", "F-150", "Explorer" };
            String[] chevy = { "Corvette", "Camaro", "Silverado" };
            String[] toyota = { "Corolla", "Camry", "Rav4" };


            String[,] parkinglot = {{ "Mustang", "F-150", "Explorer" },
                                    { "Corvette", "Camaro", "Silverado" },
                                    { "Corolla", "Camry", "Rav4" }
                                   };

            parkinglot[0, 1] = "";
            foreach(String car in parkinglot)
            {
                Console.WriteLine(car);
            }


        }

        static void ep_30() //classes
        {
            Messages mes = new Messages();
            mes.Hello();
            mes.Waiting();
            mes.Call_me();
        }

        static void ep_31() //objects
        {
            Human human1 = new Human();
            Human human2 = new Human();
            human1.name = "Rick";
            human1.age = 65;
            human2.name = "Morty";
            human2.age = 16;

            human1.Sleep();
            human2.Sleep();
            human1.Eat();
            human2.Eat();
        }

        static void ep_32() //constructors
        {
            Human human1 = new Human("Rick", 65);
            Human human2 = new Human("Morty", 16);

            human1.Sleep();
            human2.Sleep();
            human1.Eat();
            human2.Eat();

            Car car1 = new Car("Ford", "Mustang", 2022, "red");
            car1.Drive();

        }

        static void ep_33() //static
        {
            //By declaring something static it belongs to class not to an object, so you can count a number of objects that were created using this class
            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");

            Console.WriteLine(Car.numberOfCars);

        }

        static void ep_34() //overloading constructor
        {
            Car car1 = new Car("Corvette");
            Car car2 = new Car("Ford", "Mustang", 2022, "red");

            car1.ShowDetail();
            car2.ShowDetail();
        }

        static void ep_35() // inheritance
        {
            Car car = new Car("yep");
            Boat boat = new Boat();
            Bicycle bicycle = new Bicycle();

            car.go();
            boat.go();
            bicycle.go();

        }

        static void ep_36() //abstract classes
        {
            //you can't create an object with abstract class adds security

        }

        static void ep_37() // array of objets
        {
            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");
            Car car3 = new Car("Lambo");

            Car[] garage = new Car[3];

            garage[0] = car1;
            garage[1] = car2;
            garage[2] = car3;

            //Car[] garage2 = { new Car("Mustang"), new Car("Corvette"), Car("Lambo") };
            //you can create an array like above, it's much neater and it takes less steps

            Console.WriteLine(garage[0].model);
            Console.WriteLine(garage[1].model);
            Console.WriteLine(garage[2].model);


        }

        static void ep_38() // objects as arguments
        {
            Car car1 = new Car("Ford", "Mustang", 2022, "red");
            Console.WriteLine(car1.color);
            change_color(car1,"blue");
            Console.WriteLine(car1.color);
            Car new_car = copy_car(car1);

            Console.WriteLine(new_car.model + " " + new_car.color);

        }

        static void change_color(Car car, string color)//ep38
        {
            car.color = color;
        }

        static Car copy_car(Car car)//ep38
        {
            return new Car("", car.model, 0, car.color);
        }

        static void ep_39() //method override
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            dog.Speak();
            cat.Speak();


        }

        static void ep_40() //toString
        {
            Car car = new Car("Chevy", "Corvette", 2022, "blue");
            Console.WriteLine(car.ToString());

        }

        static void ep_41() //polymorphism
        {
            Car car = new Car("yep");
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Vehicle[] vehicles = { car, bicycle, boat };//they have common type that is Vehicle

            foreach(Vehicle vehicle in vehicles)
            {
                vehicle.go();
            }

        }

        static void ep_42() //interfaces
        {
            //interface declares what needs to be implemented
            //an inheriting class defines how it should do it
            //security + multiple inheritance

            Rabbit rabbit = new Rabbit();
            rabbit.Flee();

            Hawk hawk = new Hawk();
            hawk.Hunt();

            Fish fish = new Fish();
            fish.Flee();
            fish.Hunt();

        }

        static void ep_43() //lists
        {
            //to use lists you need to import:
            //using System.Collections.Generic;

            List<String> food = new List<string>();
            food.Add("pizza");
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("fries");

            food.Insert(2, "sushi");

            Console.WriteLine(food.Count);
            Console.WriteLine(food.IndexOf("sushi"));

            food.Reverse();

            foreach(String foodItem in food)
            {
                Console.WriteLine(foodItem);
            }


        }

        static void ep_44() //List of objects
        {
            List<Player> players = new List<Player>();

            Player player1 = new Player("Chad");
            Player player2 = new Player("Ichigo");
            Player player3 = new Player("Inoue");

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);

            foreach(Player player in players)
            {
                Console.WriteLine(player);
            }

        }

        static void ep_45() //getters and setters
        {
            Car car1 = new Car(30);

            Console.WriteLine(car1.Speed);
            
            car1.Speed = 600;

            Console.WriteLine(car1.Speed);

        }

        static void ep_46() //auto implemented properties
        {
            Table table = new Table("wood");

            Console.WriteLine(table.Material);

            table.Material = "metal";

            Console.WriteLine(table.Material);

        }

        static void ep_47() //enums
        {
            Console.WriteLine(Planets.Mercury + " is planet #" + (int)Planets.Mercury);

            String name = PlanetRadius.Earth.ToString();
            int radius = (int)PlanetRadius.Earth;

            Console.WriteLine($"planet: {name}");
            Console.WriteLine($"radius: {radius}km");
            Console.WriteLine($"volume: {Volume(PlanetRadius.Earth)}km^3");

        }

        static void ep_48() //generics
        {
            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 3.0, 2.0, 1.0 };
            String[] stringArray = { "1", "2", "3" };

            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);

        }
        static void displayElements<T>(T[] array)//ep48
        {
            //using <T> after methods name you can have function that can work with different data types
            foreach(T element in array)
            {
                Console.WriteLine(element);
            }
        }

        static double Volume(PlanetRadius radius) //ep47
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
            return volume;
        }

        static void ep_49() //multithreading
        {
            /*
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            Console.WriteLine(mainThread.Name);

            Thread thread1 = new Thread(CountDown);
            Thread thread2 = new Thread(CountUp);
            thread1.Start();
            thread2.Start();
            CountDown();
            CountUp();
            Console.WriteLine($"{mainThread.Name} is complete");
            */

            Thread thread1 = new Thread(() => CountDown("1st"));
            Thread thread2 = new Thread(() => CountUp("2st"));
            thread1.Start();
            thread2.Start();
        }

        static void CountDown(String name)//ep49
        {
            for(int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"Timer {name} : {i} seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"Timer {name} is complete");
        }

        static void CountUp(String name)//ep49
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Timer {name} : {i} seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"Timer {name} is complete");
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
            Console.WriteLine("\n\n10th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
        }

        static void show_ep11_15()
        {
            //---------------------------------------------------------------------------------------------------------------
            ep_11(); //If statements
            Console.WriteLine("\n\n11th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_12(); //Switches
            Console.WriteLine("\n\n12th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_13(); //logical operators
            Console.WriteLine("\n\n13th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_14(); //while loops
            Console.WriteLine("\n\n14th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_15(); //for loops
            Console.WriteLine("\n\n15th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
        }

        static void show_ep16_21()
        {
            //---------------------------------------------------------------------------------------------------------------
            ep_16(); //nested loops
            Console.WriteLine("\n\n16th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_17(); //number guessing game
            Console.WriteLine("\n\n17th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_18(); //rock paper scissors game
            Console.WriteLine("\n\n18th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_19(); //calculator
            Console.WriteLine("\n\n19th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_20_and_21(); //arrays and foreach loop
            Console.WriteLine("\n\n20th and 21st part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
        }

        static void show_ep22_25()
        {
            //---------------------------------------------------------------------------------------------------------------
            ep_22(); //methods
            Console.WriteLine("\n\n22nd part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_23(); //return keyword
            Console.WriteLine("\n\n23rd part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_24(); //method overload
            Console.WriteLine("\n\n24th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_25(); //params keyword
            Console.WriteLine("\n\n25th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
        }

        static void show_ep26_30()
        {
            //---------------------------------------------------------------------------------------------------------------
            ep_26(); //exception handling
            Console.WriteLine("\n\n26th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_27(); //conditional operator
            Console.WriteLine("\n\n27th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_28(); //string interpolation
            Console.WriteLine("\n\n28th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_29(); //multidimensional arrays
            Console.WriteLine("\n\n29th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_30(); //params keyword
            Console.WriteLine("\n\n30th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
        }

        static void show_ep31_35()
        {
            //---------------------------------------------------------------------------------------------------------------
            ep_31(); //objects
            Console.WriteLine("\n\n31st part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_32(); //constructors
            Console.WriteLine("\n\n32nd part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_33(); //static
            Console.WriteLine("\n\n33rd part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_34(); //overloading constructors
            Console.WriteLine("\n\n34th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_35(); //inheritance
            Console.WriteLine("\n\n35th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
        }

        static void show_ep36_40()
        {
            //---------------------------------------------------------------------------------------------------------------
            ep_36(); //abstract classes
            Console.WriteLine("\n\n36th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_37(); //array of objects
            Console.WriteLine("\n\n37th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_38(); //objects as arguments
            Console.WriteLine("\n\n38th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_39(); //method overriding
            Console.WriteLine("\n\n30th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_40(); //ToString method
            Console.WriteLine("\n\n40th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
        }

        static void show_ep41_45()
        {
            //---------------------------------------------------------------------------------------------------------------
            ep_41(); //polymorphism
            Console.WriteLine("\n\n41st part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_42(); //interfaces
            Console.WriteLine("\n\n42nd part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_43(); //lists
            Console.WriteLine("\n\n43rd part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_44(); //list of objects
            Console.WriteLine("\n\n44th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_45(); //getters and setters
            Console.WriteLine("\n\n45th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
        }

        static void show_ep46_49()
        {
            //---------------------------------------------------------------------------------------------------------------
            ep_46(); //auto implemented properties
            Console.WriteLine("\n\n46th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_47(); //enums
            Console.WriteLine("\n\n47th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_48(); //generics
            Console.WriteLine("\n\n48th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
            ep_49(); //multithreading
            Console.WriteLine("\n\n49th part is over. To continues press any button...");
            Console.ReadKey();
            Console.Clear();
            //---------------------------------------------------------------------------------------------------------------
        }

        static void Main(string[] args)
        {
            //show_ep1_5();
            //show_ep6_10();
            //show_ep11_15();
            //show_ep16_21();
            //show_ep22_25();
            //show_ep26_30();
            //show_ep31_35();
            //show_ep36_40();
            //show_ep41_45();
            //show_ep46_50();
            ep_49();

            //testing git
            //string x = "yeop";
            //Console.WriteLine($"To jest {x}");
        }
    }

    public class Table
    {
        public String Material { get; set; }  //if you don't need additional logic behind getter and setter, that's enought
                                       //getter will return it's value and setter will change it value
        public Table(string material)
        {
            this.Material = material;
        }

    }

    enum Planets //like dictionary in python, ep47
    {
        Mercury,
        Venus,
        Earth,
        Mars,
        Jupiter,
        Saturn,
        Uranus,
        Neptune,
        Pluto
    }

    enum PlanetRadius //like dictionary in python, ep47
    {
        Mercury = 2439,
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622,
        Pluto = 1188
    }

    public class Messages //class for ep30
    {
        public void Hello()
        {
            Console.WriteLine("Hello! Welcome");
        }
        public void Waiting()
        {
            Console.WriteLine("I am waiting");
        }
        void Bye()
        {
            Console.WriteLine("Imma head out!");
        }
        public void Call_me()
        {
            Hello();
            Waiting();
            Bye();
        }
    }

    public class Human //class for ep 31,32
    {
        public String name;
        public int age;

        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Human() { }

        public void Eat()
        {
            Console.WriteLine($"{name} ate");
        }
        public void Sleep()
        {
            Console.WriteLine($"{name} is sleeping");
        }
    }
    abstract class Vehicle //ep35, 36
    {
        public int speed = 0;
        public virtual void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }
    class Car : Vehicle //class used in ep 32,33,34,35,37,38, 40
    {
        public int wheels = 4;
        String make;
        public String model;
        int year;
        public String color;
        private int speed; 
        public static int numberOfCars;

        public Car(int speed) => this.Speed = speed;

        public Car(string model)//overloaded constructor
        {
            this.model = model;
            numberOfCars++;
        }
        public Car(string make, string model, int year, string color)//overloaded constructor
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
            numberOfCars++;
        }

        public int Speed
        {
            get { return speed; }//read
            set
            {//writable
                if (value > 500) value = 500;
                speed = value; }
        }

        public override void go()
        {
            Console.WriteLine("Car is moving");
        }

        public void Drive()
        {
            Console.WriteLine($"You drive {model}");
        }

        public void ShowDetail()
        {
            Console.WriteLine($"{make} {model} {year} {color}");
        }

        public override string ToString() //overrides method ToString to display more human information about the object, not type that is Class which was used to build that object
        {
            String message = "This is a " + make + " " + model;
            return message;
        }


    }

    class Bicycle : Vehicle //ep 35
    {
        public int wheels = 2;

        public override void go()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Boat : Vehicle //ep35
    {
        public int wheels = 0;

        public override void go()
        {
            Console.WriteLine("Boat is moving");
        }
    }

    abstract class Animal //ep 39
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal goes *brrr*");
        }
    }

    class Dog : Animal //ep 39
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes *woof*");
        }
    }

    class Cat : Animal //ep 39
    {
        public override void Speak()
        {
            Console.WriteLine("The cat goes *meow*");
        }
    }
    
    interface IPrey
    {
        void Flee();
    }

    interface IPredator
    {
        void Hunt();
    }

    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("Rabbit is running away");
        }
    }

    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("Hawk is hunting");
        }
    }

    class Fish :IPredator, IPrey
    {
        public void Hunt()
        {
            Console.WriteLine("Fish is hunting");
        }

        public void Flee()
        {
            Console.WriteLine("Fish is fleeing");
        }
    }

    class Player
    {
        public String username;

        public Player(string username)
        {
            this.username = username;
        }
        public override string ToString()
        {
            return username;
           
        }
    }



}  