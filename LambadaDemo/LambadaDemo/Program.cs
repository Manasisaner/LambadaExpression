﻿// See https://aka.ms/new-console-template for more information
using System;
namespace LambadaDemo
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wel-come in the Lambada Expression");
            PersonManagement person = new PersonManagement();
            bool check = true;
            while(check)
            {
                Console.WriteLine("Sdding the data in the list 1 \n");
                Console.WriteLine("Above option to execute the use cases");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        person.AddPerson();
                        break;
                    case 0:
                        break;
                }
            }
        }
    }
}