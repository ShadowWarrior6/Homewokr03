void now(int num){
    
    for(int i = 1; i<=num; i++){

        Console.WriteLine(i*i*i+" ");
    }
}

int x = int.Parse(Console.ReadLine()!);
now(x);