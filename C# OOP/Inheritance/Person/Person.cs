﻿namespace Person
{
    public class Person
    {
        public int name;
        public int age;

        public string Name { get; set; }
        public int Age {

            get
            {
                return this.age;
            }
            
            set
            {
                if (value < 0)
                {
                    this.age = 0;
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }
    }
}
