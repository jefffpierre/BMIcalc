using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmiCalculation
{
    public class Person
    {
        //Private Attributes
        public string firstName {get; set;}
        public string lastName { get; set; }
        public char lastNameInitial { get; set; }
        public int age { get; set; }
        public double weight { get; set; }
        public int feet { get; set; }
        public int inches { get; set; }
        public string bmiLevel { get; set; }

        //Constructors with this.attributeName
        public Person(string firstName, string lastName, double weight, int feet, int
        inches)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.weight = weight;
            this.feet = feet;
            this.inches = inches;
        }

        public Person(string firstName, char lastNameInitial, double weight, int feet, int
        inches)
        {
            this.firstName = firstName;
            this.lastNameInitial = lastNameInitial;
            this.weight = weight;
            this.feet = feet;
            this.inches = inches;
        }

        public Person(string firstName, string lastName, char lastNameInitial, int age, double weight, int feet, int inches)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.lastNameInitial = lastNameInitial;
            this.age = age;
            this.weight = weight;
            this.feet = feet;
            this.inches = inches;
        }

        public string calculateBMI()
        {
            double heightInInches = feet * 12 ;
            double BMI = weight * 703 / (heightInInches * heightInInches);
            string bmiLevel;

            if (BMI < 18.5)
                bmiLevel = "Underweight";
            if (BMI > 18.5 || BMI < 24.9)
                bmiLevel = "Normal";
            if (BMI > 25 || BMI < 29.9)
                bmiLevel = "Overweight";
            else
                bmiLevel = "Obese";
            return BMI + " : " + bmiLevel;
        }
    }
}