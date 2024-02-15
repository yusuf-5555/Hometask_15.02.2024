int MinDigit(int n){
    int b=999999;
    for(int i=n;i>0;i/=10)
    {
        if(i%10<b)b=i%10;
    }
    return b;
}
int MaxDigit(int n){
    int b=-999999;
    for(int i=n;i>0;i/=10)
    {
        if(i%10>b)b=i%10;
    }
    return b;
}
int a = Convert.ToInt32(Console.ReadLine());
int b = MinDigit(a);
int c = MaxDigit(a);
System.Console.WriteLine(b + "+" + c + "=" + (b+c));