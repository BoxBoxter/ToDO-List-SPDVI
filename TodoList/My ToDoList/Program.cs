using System;
using System.Collections.Generic;
namespace SecondProyect
{
    class Program
    {
        private static List<string> array = new List<string>();
        private static string option;
        private static string lower;
        private static int position = 0;
        static void Main(string[] args)
        {
            DisplayMenu();
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("\nCapacity: {0}", array.Capacity);
            Console.Clear();
            Console.WriteLine("--- Activity Menu ---");
            Console.WriteLine("- Add new activity");
            Console.WriteLine("- Delete activity");
            Console.WriteLine("- Print all activity");
            Console.WriteLine("- Done activity");
            Console.WriteLine("- Reorder activity");
            Console.WriteLine("- Quit");
            Console.WriteLine("---------------------");
            option = Console.ReadLine();
            lower = option.ToLower();

            if (lower == "add") {
                add();
            }
            else
            {
                if (lower == "delete") {
                    delete();
                }
                else
                {
                    if (lower == "print") {
                        print();
                    }
                    else
                        if (lower == "done") {
                            done();
                        }
                        else
                            if (lower == "reorder") {
                                reorder();
                            }
                            else
                                if (lower == "quit")
                                {
                                    System.Environment.Exit(1);
                                }
                                else
                                Console.Clear();
                                Console.WriteLine("*Incorrect option..");
                                continued();
                }
            }
        }

        private static void add()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(" What activity do you want to add?..");
            string add = Console.ReadLine();
            lower = add.ToLower();
            array.Insert(position, lower); // Insert string on the array
            position++; // Change the position to not delete existents activitys

            Console.Clear();
            Console.WriteLine("*Activity \"" + lower + "\" inserted !!");
            continued();
        }

        private static void delete()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(" What activity do you want to delete?..");
            Console.WriteLine();
            Console.WriteLine("--------- Your Activitys ----------");
            foreach (string activitys in array)
            {
                Console.WriteLine("-" + activitys);
            }
            Console.WriteLine("-----------------------------------");
            string delete = Console.ReadLine();
            lower = delete.ToLower();
            array.Remove(lower);
            // I have to check if the activity exists
            Console.Clear();
            Console.WriteLine("*Activity \"" + lower + "\" deleted !!");
            continued();
        }

        private static void print()
        {
            Console.Clear();
            Console.WriteLine("--------- Your Activitys ----------");
            foreach (string activitys in array)
            {
                Console.WriteLine("-" + activitys);
            }
            Console.WriteLine("-----------------------------------");
            continued();
        }

        private static void done()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(" What activity do you want to done?..");
            Console.WriteLine();
            foreach (string activitys in array)
            {
                Console.WriteLine("-" + activitys);
            }
            Console.WriteLine("-------------------------------------");
            string done = Console.ReadLine();
            lower = done.ToLower();
            array.Remove(lower);
            // I have to check if the activity exists
            Console.Clear();
            Console.WriteLine("*Activity \"" + lower + "\" do it !!");
            continued();
        }

        private static void reorder()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(" What activity do you want to reorder?..");
            Console.WriteLine();
            foreach (string activitys in array)
            {
                Console.WriteLine("-" + activitys);
            }
            Console.WriteLine("-----------------------------------------");
            string reorder = Console.ReadLine(); // Name of activity to reorder
            string reorder1 = reorder.ToLower();
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(" In what position do you want to reorder?..");
            foreach (string activitys in array)
            {
                Console.WriteLine("-" + activitys);
            }
            Console.WriteLine("--------------------------------------------");
            string change = Console.ReadLine(); // Name the position of the user want
            string change1 = change.ToLower();
            int index1 = array.IndexOf(reorder1); // Get old position
            int index2 = array.IndexOf(change1); // Get old position

            array.RemoveAt(index1); // Delete old position
            array.RemoveAt(index2); // Delete old position
            array.Insert(index2, reorder); // Change positons
            array.Insert(index1, change); // Change positons
            // There's a bug i can change one postion to last psotion
            Console.Clear();
            Console.WriteLine("*Position of activity \"" + reorder1 + "\" change to position of activity \"" + change1 + "\" was a succes !!");
            print();
        }

        private static void continued()
        {
            Console.WriteLine("");
            Console.WriteLine("Press Any key to continue...");
            Console.ReadLine();
            DisplayMenu();
        }
    }
}