using System;

namespace StyleCheckDemo
{
    /// <summary>
    /// Represents the main program class.
    /// </summary>
    public class Program
    {
        private readonly string _name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Program"/> class.
        /// </summary>
        /// <param name="name">The name to be used in the message.</param>
        public Program(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Displays a greeting message to the console.
        /// </summary>
        public void DisplayMessage()
        {
            Console.WriteLine($"Hello, {_name}");
        }
    }

    /// <summary>
    /// The entry point of the application.
    /// </summary>
    public class MainClass
    {
        public static void Main(string[] args)
        {
            var program = new Program("World");
            program.DisplayMessage();
        }
    }
}
