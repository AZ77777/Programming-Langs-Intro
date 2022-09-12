Console.WriteLine("Enter 5-digit number");
int number = Convert.ToInt32(Console.ReadLine());

CheckifPalindrom(number);

void CheckifPalindrom(int number)
{
    if(number >= 10000)
    {
        int division1 = number / 10000;
        int remainder1 = number % 10;
 
            if(division1 == remainder1)
            {
                number = number / 10;
                int division2 = number / 100;
                int remainder2 = number % 10;
                if(division2 == remainder2)
                    Console.WriteLine("Yes");
            }
            else 
            Console.WriteLine("No");
            
    }
    else
    Console.WriteLine("Incorrect number!");
}
