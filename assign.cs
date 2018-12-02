using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace assign
{class program
{static void main(string[]args)
{string ename, reply;
int hours=0, eid, a;
double bonus=0, tax=0, salary=0, ssf;
double grosssalary=0, netsalary=0;
console.clear();
console.write("management of employee salary");
console.write("\n\n");
while (true)
{
    console.write("enter name ");
    ename = console.readline();
    Console.Write("enter id ");
    eid = Convert.toInt32(console.Readline());
    System.Console.Writeline("employees");
    console.writeline("-------");
    console.writeline("month.");
    console.writeline("hours");
    console.writeline("evening");
    console.writeline("choose type of employee");
    a=Convert.toint32(console.readline());
    switch (a)
    {
        case 1:
        salary =1000000;
        tax =salary*18/100;
        ssf =salary*3/100;
        netsalary = salary -tax-ssf;
        console.write("employee records\n");
        console.writeline("--------------");
     console.write("\n\n");
     console.writeline("employee name {0}\n",ename);
     console.writeline("employee id {0}\n", eid);
     console.writeline("gross salary php {0:0.00}",netsalary);
     break;
     case 2:
     console.write("enter hours worked:");
     hours = convert.toInt32(console.readline());
     console.write("enter salary per hour ");
     salary = convert.todouble(console.readline());
     grosssalary = (hours * salary);
     console.write("\n");
     console.writeline("gross salary {0:0.00} ", grosssalary);
     console.write("\n");
     console.write("\n");
     tax =grosssalary * 18/100;
     netsalary =grosssalary-tax;
     console.write("employee records\n\n");
     console.writeline("------------");
     console.write("\n\n");
     console.writeline("employee name {0}", ename);
     console.writeline("gross salary {0:0.00}", grosssalary);
     console.write("\n\n");
     console.writeline("the tax of 18 {0}", tax);
     console.writeline("netsalary php {0:0.00}", netsalary);
     break;
     case 3:
     console.write("enter hours worked ");
     hours =onvert.toInt32(console.readline());
     console.write("enter salary /hours ");
     salary = convert.todouble(console.readline());
     grosssalary = (hours * salary);
     bonus = grosssalary * 0.15/100;
     console.write("\n");
     console.writeline("gross salary php{0:0.00} ", grosssalary);
     console.write("\n\n");
     console.write("\n\n");
     tax = grosssalary* 18/100;
     netsalary =grosssalary - salary - tax + bonus;
     console.write("employee records");
     console.writeline("------------");
     console.write("\n\n");
     console.writeline("employee name {0}", ename);
     console.writeline("gross salary php{0:0.00}",grosssalary);
     console.writeline("evening bonus php {0:0.00}",bonus);
     console.write("\n\n");
     console.writeline("the tax of 18% {0}\n", tax);
     console.writeline("net salary {0:0.00}", netsalary);
     break;
     console.writeline("invali choice");
     break;
    }
     console.write("go on? Y/N ");
    reply = console.readline();
    if (reply == "y" )
    {continue;}
    else if (reply =="n")
    {console.write("exit");
    console.write("\n\n");
    break;}
} }}}