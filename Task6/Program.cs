﻿ void Divisors(int x){
    for(int i=1;i<=x;i++){
        if(x%i==0)System.Console.WriteLine(i);
    }
 }
int x=Convert.ToInt32(Console.ReadLine());
Divisors(x);