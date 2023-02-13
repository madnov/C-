int FindFactorial(int n)
{
   if (n == 1) return 1;
   else return n + FindFactorial(n -1);
}


Console.Clear();

Console.WriteLine(FindFactorial(10));