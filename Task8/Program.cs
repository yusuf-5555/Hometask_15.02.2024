void MinNumber(int a, int b, int c, int d){
    int [] arr = new int[3];
    for(int i=0;i<a;i++){
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
    int e=-99999;
    for(int i=0;i<=arr[3];i++)
    {
        if(arr[i]>e)e=arr[i];
    }
    System.Console.WriteLine(e);
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());
MinNumber(a,b,c,d);