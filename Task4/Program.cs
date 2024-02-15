 int Pow(int x, int y){
    int b=1;
    for(int i=0;i<y;i++){
        b=b*x;
    }
    return b;
 }
 int x = Convert.ToInt32(Console.ReadLine());
 int y = Convert.ToInt32(Console.ReadLine());
 System.Console.WriteLine(Pow(x,y));
