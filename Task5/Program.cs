
void Swap(ref int a, ref int b)
{
    int c;
    c=a;
    a=b;
    b=c;
    System.Console.WriteLine(a);
    System.Console.WriteLine(b);
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Swap(ref a,ref b);