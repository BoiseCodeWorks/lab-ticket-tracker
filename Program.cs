using System;
using TicketTracker.Project;

namespace TicketTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Ticket Tracker\nPress any key to continue");
            Console.ReadLine();
            App app = new App();
            app.Run();
        }
    }
}
