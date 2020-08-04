using System;
using System.Collections.Generic;
using System.Text;

namespace HW11
{
    public override int Age
    {
         if (value < 1 || value > 20)
                {
            Console.WriteLine("Возраст от 1 до 20");
            Console.WriteLine("Ошибка ввода, Возраст должен быть от 1 до 20");
        }
                else age = value;
    }
    public override int Weight
        {
            get
    public override int Weight
            {
                if (value < 1 || value > 850)
                {
                    Console.WriteLine("Вес от 1 до 850");
                    Console.WriteLine("Ошибка ввода, Вес должен быть от 1 до 850");
                }
                else weight = value;
            }
        }
        public Cow(string name, int age, string gender, int weight) : base(name, age, gender, weight)
        {
        }

        public override void Eat()
        public override string Feed { get; set; }

        public Cow(string name, int age, string gender, int weight, string korm) : base(name, age, gender, weight, korm)
        {
            Console.WriteLine("Идет прием пищи");
        }

        public override void WhatFeed()
        public override void Eat(Animal animal)
        {
            Console.WriteLine($"{animal.GetType()} Корм: {animal.Feed}");
        }
    }
}
}


