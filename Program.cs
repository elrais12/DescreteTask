 // reading the ism num 
Console.WriteLine("enter the in ");
int s = int .Parse(Console.ReadLine());
// reading the 2nd num 
Console.WriteLine(" enter the 2n ");
int e = int .  Parse(Console.ReadLine());
int sum = 0;
Console.WriteLine(" the prime numbers from {0} to {1} is",s,e);
for (int i = s; i <= e; i++)
{
    for ( int x = 1; x<= i; x++)
    {
        if (i % x == 0)
            sum++; 
    }
    if ( sum== 2)
    {
        Console.WriteLine(i);
        sum = 0; 

    }
    else
    {
        sum = 0; 
    }
    
}