﻿using System.Runtime;

namespace challengeApp_
{
    public class Employee
    {
        private List<int> score = new List<int>();
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int age { get; private set; }
        public int Result { get; private set; }

        public int maxResult
        {
            get
            {
                return this.score.Sum();
            }

        }
        public void AddScore(int number)
        {
            this.score.Add(number);
        }
    }
}
