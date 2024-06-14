using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

//string Brand, colour, price, Type;
//string Toyotap, Yamahap;
////price = Toyotap + 2000;
////price = Yamahap + 2000;
//Console.Write("\tTHE FASTEST CAR ");
//Console.WriteLine($"\nType of car \tcolour ");
//Console.WriteLine($"Toyota\t\t red black");
//Console.WriteLine($"Yamaha\t\tred bluw ");

//Console.WriteLine($"\nWhat would you choose");
//Console.Write("Brand :");
//Brand = Convert.ToString(Console.ReadLine());
//Console.WriteLine($"\nWhat colour would you like to choose");
//Console.Write("Colour :");
//colour = Convert.ToString(Console.ReadLine());
//Console.WriteLine($"\nGas's type of the car");
//Console.Write("Gas type :");
//Type = Convert.ToString(Console.ReadLine());

//Console.WriteLine("\n\tTHE LAST DICITION ");
//Console.WriteLine($"\t{Brand}\t{colour}\t{Type}");
//Console.WriteLine($"\tBrand\tcolour\tType");




//string id, name;
//double commision, sale, rate,salary,price,tax;


//Console.WriteLine("Please fill your information");
//Console.Write("You name:");
//name = Convert.ToString(Console.ReadLine());
//Console.Write("Your id:");
//id = Convert.ToString(Console.ReadLine());

//Console.Write("Your salary: ");
//salary = Convert.ToDouble(Console.ReadLine());

//Console.Write("Sale total: ");
//sale = Convert.ToDouble(Console.ReadLine());

//Console.Write("Rate: ");
//rate = Convert.ToDouble(Console.ReadLine());


//commision = (sale * rate)/100 ;
//price = salary + commision;
//tax = price *0.05;

//Console.WriteLine($"\n\n\t(salary:{salary} \tsale:{sale:N2} \tcomission:{commision} \tTax:{tax:N2})");



//Console.WriteLine($"\tNet:{price:N2}");



//double a = 1, b = 2, x = 3, y = 4;

//var left = (a + b) / (3 * a * b);

//var right = ((x * x) * (y * y)) / x-y ;

//Console.WriteLine($"result:{left - right}");

double a = 1, b = 2, x = 3, y = 4;


//sqr(X)= 
//abs(4) = 
//PI (-5)
//pow (2,20) =
var pi = Math.PI;

var ex = Math.Exp(x);
var up = ex * Math.Sqrt(Math.Pow(a,2) + Math.Pow(b, x - y));
var down = (2 * pi * Math.Pow(x, 2)) -  Math.Pow(y, 2);

Console.WriteLine(up / down);
