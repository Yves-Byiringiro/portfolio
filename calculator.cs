using System;
using System.Collections.Generic;
using System. Linq;
using System.Text;
using System .Threading.Tasks;

namespace Calculate{}

static void Main(string[] args)
{
    char choice;
    var operation1=new Calculate();
    Console.WriteLine("enter first number");
var num1=Convert.ToDouble( Console.ReadLine());
Console.WriteLine("enter the second number");
var num2=Convert.ToDouble(Console.ReadLine());
Console.ReadKey();
choice= Convert.ToDouble(Console.ReadLine());
if(choice=='+')
{
    System.Console.WriteLine(num1+num2);
}
else if(choice=='-')
{
    System.Console.WriteLine(num1-num2);
}
else if(choice=='*')
{
    System.Console.WriteLine(num1*num2);
}
else if(choice=='/'){
    System.Console.WriteLine(num1/num2);
}
else{
    System.Console.WriteLine("invalid choice");
}

}