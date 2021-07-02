using System;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Phonebook phonebook = new Phonebook();
                    

            while (true)
            {
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("Please choose one of the available options:");
                Console.WriteLine("Presse 1: show an existing contact");
                Console.WriteLine("Presse 2: add a new contact");
                Console.WriteLine("Presse 3: delete a contact");
                Console.WriteLine("Presse 'q': exit the phonebook");
                Console.WriteLine("------------------------------------------------------------");

                var input = Console.ReadLine();
                

                if (input == "q")
                {
                    break;
                }

                var option = 0;

                try
                {
                    option = int.Parse(input);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }


                switch (option)
                {
                    
                    case 1: 
                        Console.WriteLine("Please type the name of the contact");
                        var name = Console.ReadLine();
                        phonebook.ShowContact(name);
                        break;
                    case 2:
                        Console.WriteLine("Please type  the name of the contact:");
                        name = Console.ReadLine();
                        Console.WriteLine("Please type the phone number of the contact:");
                        var number = Console.ReadLine();
                        phonebook.AddContact(name, number);                        
                        break;
                    case 3:
                        Console.WriteLine("Please type the name of the contact");
                        name = Console.ReadLine();
                        phonebook.DeleteContact(name);
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
