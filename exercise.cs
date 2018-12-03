using System;
using System. Collections. Generic;
using System. Text;
using System. Threading. Tasks;

namespace ConsoleApp1
{
    class calculate
{
    public double Add(double n1, double n2)
    { 
        return n1+n2;
        
    }
    public double Substract(double n1, double n2)
    {
        if (n1 > n2)
        {

        return (n1-n2);
        }
        else
        {
             return (0);
        }
    }
public int Divide(int n1, int n2)
{
    if(n1>n2 && n1!=0)
    {
        return n1/n2;
    }
        else
        {
            
                return (0);
            
        }
}
public int Multiply(int n1, int n2)
{

    return n1*n2;
}


  static void main(string[] args)
  {
      var obj= new calculate;
      Console.WriteLine("enter number1");
      var n1 =Console.ReadLine();
      Console.WriteLine("enter number2");
      var n2=Console.ReadLine();
      char oper;
      switch (oper)
      {
          case '+':
          Console.WriteLine(n1+n2);
          break;
      }


  }