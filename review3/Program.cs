using review3;

internal class Program
{
    private static void Main(string[] args)
    {
        //1
        bool isValid = ValidateEmail.IsValidEmail("asmita@gmail.com");
        if (!isValid)
        {
            Console.WriteLine(" valid email input");
        }
        else
        {
            Console.WriteLine("  not a valid email input");
        }

        //2)
        bool isValidPassword = ValidatePassword.IsValidPassword("Asmita@123");

        if (isValidPassword)
        {
            Console.WriteLine(" valid password input");
        }
        else
        {
            Console.WriteLine("  not a valid password input");
        }
        //3)

        bool isValidNum = ValidatePhoneNumber.IsValidPhoneNumber("+91-1234567890");

        if (isValidNum)
        {
            Console.WriteLine(" valid mobile number input");
        }
        else
        {
            Console.WriteLine("  not a valid mobile number input");

        }

        //4
        string sentence = "This is is a test test";


        var duplicates = FindDuplicateWord.FindDuplicateWordEx(sentence);

        Console.WriteLine("duplicate words: " + string.Join(", ", duplicates));

        //5
        try
        {
            DivideByZeroExce.Div();
        }catch(DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }

        //6 
        try
        {
            AgeExce.ValidateAge(0);
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine(ex.Message);
        }

        //7

        BankingSystem bank = new BankingSystem(5000);

        try
        {

            bank.Withdraw(30000000);
        }
        catch (InsufficientFundException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // 8
        try
        {
            ProductStock productStock = new ProductStock(0);
            productStock.GetStockProduct(3);
        }
        catch (ProductOutOfStockException ex)
        {
            Console.WriteLine(ex.Message);
        }

        //9 

        EvenOddChecker checker = new EvenOddChecker();
        checker.IsEvenOdd();

        //checker.StringLengthCom();

        LambdaExample example = new LambdaExample();
        example.FindNum();

        example.FindMaxOfTwo();

    }
}