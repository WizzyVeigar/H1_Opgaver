using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Files
{
    class GUIMenu
    {
        IOController controller = new IOController();

        internal void StartMenu()
        {
            Console.Clear();
            Console.WriteLine(
                     "What would you like to do? \n" +
                     "1. Add File \n" +
                     "2. Delete File \n" +
                     "3. Display Files \n" +
                     "4. Add Folder \n" +
                     "5. Search File \n" +
                     "6. Other stuff ex JPEG \n" +
                     "7. Exit" +
                     "\n" +
                     "\n" +
                     "Enter your choice: ");

            #region ihavestupidfriends
            //Dennis made this
            //Actually it was Peter
            //int hello = 0;
            //int.TryParse(Console.ReadLine(), out hello);
            #endregion
            //Checks for correct input
            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    break;
            }
            StartFunction(input);
            Console.ReadKey();
        }


        /// <summary>
        /// Start whatever feauture is chosen by <paramref name="choice"/>
        /// </summary>
        /// <param name="choice">Users choice for which feature he/she would like to run</param>
        public void StartFunction(string choice)
        {
            string data = "";
            Console.Clear();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("What is the name of your new file?");
                    string fileName = Console.ReadLine();
                    Console.WriteLine("What is written in the document?");
                    data = Console.ReadLine();
                    controller.CreateFile(fileName, data);
                    Console.WriteLine("Success!");
                    break;

                case "2":
                    Console.WriteLine("What is the name and extension of the file you want deleted?");
                    data = Console.ReadLine();

                    if (controller.DeleteFile(data))
                        Console.WriteLine("File deleted successfully");
                    else
                        Console.WriteLine("Something went wrong, check if you typed the name correctly");
                    break;

                case "3":
                    //CW files to console.
                    foreach (string file in controller.DisplayFiles())
                    {
                        Console.WriteLine(file);
                    }
                    break;

                case "4":
                    Console.WriteLine("What is the path of the new folder?");
                    data = Console.ReadLine();

                    if (controller.AddFolder(data))
                        Console.WriteLine("Directory created successfully");
                    else
                        Console.WriteLine("Something went wrong, check if you typed everything correctly");
                    break;

                case "5":
                    Console.WriteLine("What directory do you want to search in?");
                    string directory = Console.ReadLine();

                    Console.WriteLine("Search for file containing: ");
                    data = Console.ReadLine();
                    foreach (string file in controller.SearchForFiles(directory,data))
                    {
                        Console.WriteLine(file);
                    }
                    break;

                case "6":
                    //Does something
                    //Could change directory
                    break;

                case "7":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Wrong input, stupid!");
                    break;
            }
        }

    }
}
