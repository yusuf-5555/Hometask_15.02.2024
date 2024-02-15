using System.Runtime.InteropServices;

int Add(int a, int b){
    return a+b;
}
int Sub(int a, int b){
    return a-b;
}
int Mul(int a, int b){
    return a*b;
}
int Div(int a, int b){
    return a/b;
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Add:" + Add(a,b));
System.Console.WriteLine("Subtract:" + Sub(a,b));
System.Console.WriteLine("Multiply:" + Mul(a,b));
System.Console.WriteLine("Division:" + Div(a,b));