using System;
using System. Collections. Generic;
using System. Text;
using System. Threading. Tasks;
namespace assign
{
    class program
{
    static void Main(string[] args)
{
    string ename, reply;
int hours=0, eid, a;
double bonus=0, tax=0, salary=0, ssf;
double grosssalary=0, netsalary=0;
Console.Clear();
Console.Write("management of employee salary");
Console.Write("\n\n");
while (true)
{
    Console.Write("enter name: ");
    ename = Console.ReadLine();
    Console.Write("enter id ");
    eid = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("employees");
    Console.WriteLine("-------");
   Console.WriteLine("month.");
    Console.WriteLine("hours");
    Console.WriteLine("evening");
    Console.WriteLine("choose type of employee");
    a=Convert.ToInt32(Console.ReadLine());
    switch (a)
    {
        case 1:
        salary =1000000;
        tax =salary*18/100;
        ssf =salary*3/100;
        netsalary = salary -tax-ssf;
        Console.Write("employee records\n");
        Console.WriteLine("--------------");
     Console.Write("\n\n");
     Console.WriteLine("employee name {0}\n",ename);
     Console.WriteLine("employee id {0}\n", eid);
     Console.WriteLine("gross salary php {0:0.00}",netsalary);
     break;
     case 2:
     Console.Write("enter hours worked:");
     hours = Convert.ToInt32(Console.ReadLine());
     Console.Write("enter salary per hour ");
     salary = Convert.ToDouble(Console.ReadLine());
     grosssalary = (hours * salary);
     Console.Write("\n");
     Console.WriteLine("gross salary {0:0.00} ", grosssalary);
     Console.Write("\n");
     Console.Write("\n");
     tax =grosssalary * 18/100;
     netsalary =grosssalary-tax;
      Console.Write("employee records\n\n");
     Console.WriteLine("------------");
     Console.Write("\n\n");
     Console.WriteLine("employee name {0}", ename);
     Console.WriteLine("gross salary {0:0.00}", grosssalary);
     Console.Write("\n\n");
     Console.WriteLine("the tax of 18 {0}", tax);
     Console.WriteLine("netsalary php {0:0.00}", netsalary);
     break;
     case 3:
     Console.Write("enter hours worked ");
     hours =Convert.ToInt32(Console.ReadLine());
     Console.Write("enter salary /hours ");
     salary = Convert.ToDouble(Console.ReadLine());
     grosssalary = (hours * salary);
     bonus = grosssalary * 0.15/100;
     Console.Write("\n");
     Console.WriteLine("gross salary php{0:0.00} ", grosssalary);
     Console.Write("\n\n");
     Console.Write("\n\n");
     tax = grosssalary* 18/100;
     netsalary =grosssalary - salary - tax + bonus;
     Console.Write("employee records");
     Console.WriteLine("------------");
     Console.Write("\n\n");
     Console.WriteLine("employee name {0}", ename);
     Console.WriteLine("gross salary php{0:0.00}",grosssalary);
     Console.WriteLine("evening bonus php {0:0.00}",bonus);
     Console.Write("\n\n");
     Console.WriteLine("the tax of 18% {0}\n", tax);
     Console.WriteLine("net salary {0:0.00}", netsalary);
     break;
    
    }
     Console.Write("go on? Y/N ");
    reply = Console.ReadLine();
    if (reply == "y" )
    {continue;}
    else if (reply =="n")
    {Console.Write("exit");
    Console.Write("\n\n");
    break;
    }
} }}}