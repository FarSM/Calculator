internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Console Calculator\r");
        Console.WriteLine("------------------\n");

        bool endApp = false;

        while (!endApp)
        {
            string Input1 = "";
            string Input2 = "";
            string Operation = "";
            double result = 0;

            Console.WriteLine("Type the first number and press any key to enter: ");
            Input1 = Console.ReadLine();
            double cleanNum1 = 0;
            while (!double.TryParse(Input1, out cleanNum1))
            {
                Console.WriteLine("Please enter an integer value: ");
                Input1 = Console.ReadLine();
            }

            Console.WriteLine("Type the second number and press any key to enter: ");
            Input2 = Console.ReadLine();
            double cleanNum2 = 0;
            while (!double.TryParse(Input2, out cleanNum2))
            {
                Console.WriteLine("Please enter an integer value: ");
                Input1 = Console.ReadLine();
            }


            Console.WriteLine("\nChoose an option for the operation to be conducted:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");
            Operation = Console.ReadLine();

            try
            {
                result = Calculator.DoOperation(cleanNum1, cleanNum2, Operation);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("\nThis operation will result in a mathematical error.\n");
                }
                else
                {
                    Console.WriteLine("\nResult : {0:0.####}\n", result);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Oh No1 An exception occurred trying to do the math.\nDetails: " + e.Message);
            }

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Press 'n' to close the app or any other key to continue: ");
            if(Console.ReadLine() == "n") endApp=true;

            Console.WriteLine("/n");

        }
    }
}