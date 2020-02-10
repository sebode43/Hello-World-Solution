using System;

namespace HelloWorldProject {
    class Program {
        static void Main(string[] args) {

            var s1 = new Student();
            s1.Name = "Fred";
            s1.FavoriteColor = "Blue";
            s1.FavoriteNumber = 88;
            s1.ToConsole();

            var s2 = new Student();
            s2.Name = "Betty";
            s2.FavoriteColor = "Green";
            s2.FavoriteNumber = 27;
            s2.ToConsole();

            Console.WriteLine("This is my Hello World C# Program");
            Console.WriteLine("This is another line.");

            var counter = 1; //to comment one line
            if (counter == 0) {
                Console.WriteLine("Counter is 0");
                }
            else {
                Console.WriteLine("Counter is not zero");
                }
            counter += 1;
            Console.WriteLine("Counter value is {0}", counter);

            counter++; //same thing as counter = counter + 1, counter += 1
            Console.WriteLine($"Count value is {counter}");

            var sum = 0;
            for (var index = 0; index <= 1000; index++) {
                sum += index;
                }
            Console.WriteLine($"Sum is {sum}");
            }
        }
    }
