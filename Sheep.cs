using System;
using System.Collections.Generic;
using System.Text;

namespace HW11
{
    public override int Age
    {
        {
            if (value < 1 || value > 30)
            {
                Console.WriteLine("Возраст от 1 до 10");
                Console.WriteLine("Ошибка ввода, Возраст должен быть от 1 до 10");
            }
            else age = value;
        }
    }
    public override int Weight
    {
        get
        {
            if (value < 1 || value > 740)
            {
                Console.WriteLine("Вес от 1 до 45");
                Console.WriteLine("Ошибка ввода, Вес должен быть от 1 до 45");
            }
            else weight = value;
        }
    }
    public Sheep(string name, int age, string gender, int weight) : base(name, age, gender, weight)
    {
    }

    public override void Eat()
        public override string Feed { get; set; }

    public Sheep(string name, int age, string gender, int weight, string korm) : base(name, age, gender, weight, korm)
    {
        Console.WriteLine("Идет употребление пищи");
    }

    public override void WhatFeed()
        public override void Eat(Animal animal)
    {
        Console.WriteLine($"{animal.GetType()} Корм: {animal.Feed}");
    }
}
