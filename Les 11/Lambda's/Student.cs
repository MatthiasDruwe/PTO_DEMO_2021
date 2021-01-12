using System;
using System.Collections.Generic;
using System.Text;

namespace Lambda_s
{
    class Student
    {
        private string name;
        private char sex;
        private int score;

        public Student(string name, char sex, int score)
        {
            this.name = name;
            this.sex = sex;
            this.score = score;
        }

        public string Name { get => name; set => name = value; }
        public char Sex { get => sex; set => sex = value; }
        public int Score { get => score; set => score = value; }
    }
}
