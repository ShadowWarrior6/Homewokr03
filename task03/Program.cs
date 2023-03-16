Console.WriteLine("ввидите число");
string number = Console.ReadLine()!;

void Checkingnumber(string number){

  if (number[0]==number[4] || number[1]==number[3]){
    
    Console.WriteLine($"красва это {number} палиндром ");
    }
    else Console.WriteLine($"это {number} не палиндром");
}
if(number!.Length==5){
    Checkingnumber(number);
}
else Console.WriteLine("ввидите правильное число");

