using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;

namespace ClassNumber13
{
    class Program
    {
        //public delegate bool TestDelegate(int input);
        //private static TestDelegate ObjTestDele;


        public delegate bool TrueOrFalse(int input);

        public static TrueOrFalse objDel;


        static void Main(string[] args)
        {
            // ye delegate tarif mikoni bool 3 ta func midi agar az adadee vorodi bozorg bood true dar gheyre in sorat false

            
            Console.WriteLine("Enter a Line");

            var holder = Convert.ToInt32(Console.ReadLine());

            objDel = DelegateExample;
            objDel += DelegateExample;

            Delegate[] del = objDel.GetInvocationList();
            
            

            foreach (TrueOrFalse item in del)
            {
                if (item(holder))
                {
                    continue;
                }
                else
                {
                    break;
                }
            }

            //install newton Soft

            //if (objDel(holder) == true)
            //{
            //    objDel += DelegateExampleTwo;
            //    objDel += DelegateExampleThree;
            //}
            //else
            //{
                
            //}


            //var TrueORFalse = DelegateExample(holder);
            //if (TrueORFalse)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}


            /////delegate
            //Dogs objDogs = new Dogs();
            //ObjTestDele = GetName;
            //ObjTestDele += objDogs.getName;

            //ObjTestDele();


            ///3 ta text az karbar migirim bad yek addad migirim ta 10 nahayat 
            ///yek listi hastesh ke az in do nooo tashkil shode 
            ///bad bege length eshon az on addad kamtar bood ro biyaree

            //List<string> stringHolder = new List<string>();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Enter The Text");
            //    string  result = Convert.ToString(Console.ReadLine());
            //    if (string.IsNullOrEmpty(result))
            //    {
            //        Console.WriteLine("the Result is null");
            //        result += "BehzadTest" + i;
            //    }
            //    stringHolder.Add(result);
            //}

            //Console.WriteLine("Enter A Number");

            //int NumberResult = Convert.ToInt32(Console.ReadLine());

            //(from c in stringHolder
            //          where c.Length > NumberResult
            //           select c).ToList().ForEach(x => Console.WriteLine(x));

            ////////////////////////////////////////////////////////////////////////////////////
            //Func<int> func = () => 3 * 5;
            /////
            //Action action = () => TestMethod(); 
            //action.Invoke();


            ///////////////////////////////////////////////////////////////////////////////////
            //Dogs dogs = new Dogs();
            //dogs.getName();

            //List<Dogs> lstDogs = new List<Dogs>{ 
            //    new Dogs { Name = "Misha" , Number= 12, IsHappy= true},
            //    new Dogs { Name = "rocky" , Number= 20, IsHappy= true},
            //    new Dogs { Name = "jessie" , Number= 10, IsHappy= false},
            //    new Dogs { Name = "olly" , Number= 12, IsHappy= true},
            //    new Dogs { Name = "bungy" , Number= 78, IsHappy= true},
            //    new Dogs { Name = "bunny" , Number= 14, IsHappy= false},
            //    new Dogs { Name = "padari" , Number= 15, IsHappy= true},
            //};



            //var lst = from c in lstDogs
            //          where c.Number > 14
            //          select c;

            //var lstSecond = (from c in lstDogs
            //          where c.Name.StartsWith("b") 
            //          select c).ToList();

            //foreach (var item in lstSecond)
            //{
            //    Console.WriteLine(item.Name);
            //}


            //foreach (var item in lst)
            //{
            //    Console.WriteLine(item.Name);
            //}

        }
        public static void GetName()
        {
            Console.WriteLine("Hello Dogs");
        }
        public static bool DelegateExample(int i)
        {

            Console.WriteLine("Triggered");

            if (i > 12)
            {
                Console.WriteLine("Bigger");
                return false;
            }
            else
            {
                Console.WriteLine("Lesser");
                return true;
            }
        }

    }

    public partial class Dogs
    {
        public void getName()
        {
            Console.WriteLine($"The name is {Name}");
        }


        public void TestDel(bool TrueOrFalse)
        {
            Console.WriteLine($"TrueOrFalse {TrueOrFalse}");
        }
    }
    public partial class Dogs
    {
        public int Number { get; set; }

        public string Name { get; set; }

        public bool IsHappy { get; set; }


    }



}