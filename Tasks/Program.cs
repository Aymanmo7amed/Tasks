using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    task 4
            // write program هتستقبل من اليوزر رقم وهتجيب جدول الضرب ليه من 1:12
            //start:
            //    Console.Write("Enter the num : ");
            //    int num = int.Parse(Console.ReadLine());
            //    for (int i = 1; i <= 12; i++)
            //    {
            //        Console.WriteLine($"{num} * {i} = {num * i}  ");
            //    }
            //    Console.Write("If you want other num enter (y) , to exit enter another any key : ");
            //    string ans = Console.ReadLine();
            //    if (ans == "y" || ans == "Y")
            //    {
            //        goto start;
            //    }
            //    else
            //    {
            //        Console.WriteLine("i wish you found what you want...");
            //    }



            //task 5
            // هنستقبل من اليوزر اضلاغ مثلث ونحدد نوعه
            //start:
            //    Console.Write("Enter the side1 of the triangle: ");
            //    double x = double.Parse(Console.ReadLine());
            //    Console.Write("Enter the side1 of the triangle: ");
            //    double y = double.Parse(Console.ReadLine());
            //    Console.Write("Enter the side1 of the triangle: ");
            //    double z = double.Parse(Console.ReadLine());
            //    Console.WriteLine("______________________________");
            //    if (x == y && y == z)
            //    {
            //        Console.WriteLine("The Triangle is equilateral");
            //    }
            //    else if (x != y && y != z)
            //    {
            //        Console.WriteLine("The Triangle is scalene");

            //    }
            //    else
            //    {
            //        Console.WriteLine("The Triangle is isosceles");

            //    }
            //    Console.WriteLine("");
            //    Console.Write("If you want another operation enter (y) , to exit enter another any key: ");
            //    string ans = Console.ReadLine();
            //    if (ans == "y" || ans == "Y")
            //    {
            //        goto start;
            //    }
            //    else
            //    {
            //        Console.WriteLine("I wish you found what you want...");


            // task 6
            // هنستقبل من اليوزر ارراي لمجموعه من الاسماء ثم يدخل اليوزر الاسم لو موج نطلعله انه موجود او لا 
            //Console.Write("enter the numbers of names you want to add: ");
            //int size = int.Parse(Console.ReadLine());
            //string[] names = new string[size];
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter the name {i + 1} : ");
            //    names[i] = Console.ReadLine();
            //}
            //Console.Write("Enter the name you want to search : ");
            //string sch = Console.ReadLine();
            //for (int j = 0; j < size; j++)
            //{
            //    if (sch == names[j])
            //    {
            //        Console.WriteLine($"The Name {sch} is found.....");
            //    }
            //    else
            //    {

            //    }


            //}

            //Console.WriteLine("error... the name is not found ! ");


            // task 7
            // هستقبل ارراي فيها ارقام وعايزها تطبع كل رقم عدد مرات يساوي الرقم نفسه
            //Console.Write("enter the num of numbers you want add: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] nums = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Enter the num {i + 1} : ");
            //    nums[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("-------------------");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < nums[i]; j++)
            //    {
            //        Console.Write($"{nums[i]} ");
            //    }
            //}

            //task8
            // استقبل من اليوز خمس ارقام ولو دخل حاجه غير رقم خليه يعيد الادخال 
            //int[] nums = new int[5];
            //for (int i = 0; i < 5; i++)
            //{

            //    try
            //    {

            //        Console.Write($"Enter the num {i + 1} : ");
            //        nums[i] = int.Parse(Console.ReadLine());
            //    }

            //    catch (FormatException)
            //    {

            //        Console.Write($"Enter the num {i + 1} : ");
            //        nums[i] = int.Parse(Console.ReadLine());

            //    }

            //}


        }
    }

    
}

    

