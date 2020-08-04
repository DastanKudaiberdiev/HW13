using System;
using System.Collections.Generic;
using System.Text;

namespace HW11
{
    abstract class Beasts
    {
        public abstract int Age { get; set; }
        public abstract int Weight { get; set; }
        public abstract string Feed { get; set; }

        public Beasts(string name, int age, string gender, int weight)

        public Beasts(string name, int age, string gender, int weight, string feed)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Weight = weight;
            Feed = feed;
        }

        public abstract void Eat();
        public abstract void WhatFeed();
        public abstract void Eat(Beasts animal);
  }
}
