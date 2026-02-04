using Lommeregner;

 class Program
{
     static void Main(string[] args)
    {
       
        var cancel = false;
        do
        {
            Console.WriteLine("Which operation do you want to perform");
            var operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine(Operations.Addition());
                    break;
                case "-":
                    Console.WriteLine(Operations.Substraction());
                    break;
                case "*":
                    Console.WriteLine(Operations.Multiplication());
                    break;
                case "/":
                    Console.WriteLine(Operations.Division());
                    break;
                case "sqrt":
                    Console.WriteLine(Operations.Sqrt());
                    break;
                case "pow":
                    Console.WriteLine(Operations.Pow());
                    break;
                case "q":
                    cancel = true;
                    break;
                default:
                    Console.WriteLine("wrong key, please try again");
                    break;
            }
        }
        while (cancel == false);
        
    }
}