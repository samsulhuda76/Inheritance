﻿using System;

namespace LatihanInheritance
{
    public class Person
    {
        public Person(string Name, int Age)
        {
            name = Name;
            age = Age;
        }

        //properties
        public string name { get; set; }
        public int age { get; set; }

        public void GetNameAndAge()
        {
            Console.WriteLine("The Person has name : {0} and age : {1}", name, age);
        }
    }
}