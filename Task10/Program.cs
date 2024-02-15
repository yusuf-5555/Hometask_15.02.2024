int Max(int val1, int val2){
    if(val1>val2)return val1;
    else{
        return val2;
    }
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Max(a,b));
