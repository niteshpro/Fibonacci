namespace Fibonacci
{
    public static class Program
    {
        static void Main()
        {
            int n1=0, n2=1,n3,size=15;
            Console.Write(n1 +" "+ n2+ " ");
            for(int i = 2; i < size; i++)
            {
                n3= n1+n2;
                Console.Write(n3+" ");
                n1 = n2;
                n2= n3;
            }


        }
    }
}