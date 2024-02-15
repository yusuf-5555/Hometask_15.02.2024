int EvenCount(int n)
{
    int cnt=0;
    for(int i=n;i>0;i/=10){
if(i%2==0)cnt++;
    }
    return cnt;
}
 int OddCount(int n)
 {
    int cnt1=0;
    for(int i=n;i>0;i/=10){
if(i%2!=0)cnt1++;

    }
    return cnt1;
 }

int DigitCount(int n)
{
    int cnt1=0;
    for(int i=n;i>0;i/=10){
cnt1++;

    }
    return cnt1;
}

int SumDigit(int n)
{
        int cnt1=0;
    for(int i=n;i>0;i/=10){
    
cnt1+=i%10;

    }
    return cnt1;
}

 int a = Convert.ToInt32(Console.ReadLine());
 var b = EvenCount(a);
 var c = OddCount(a);
 var d = DigitCount(a);
 var e = SumDigit(a);
 Console.WriteLine("Even:" + b);
 Console.WriteLine("Odd:" + c);
  Console.WriteLine("Digit:" + d);
   Console.WriteLine("Sum:" + e);