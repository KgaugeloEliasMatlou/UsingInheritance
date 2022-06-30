using System;
namespace ClassTracker
{
    class Program
    {
        static void Main()
        {
            creditCourse creditCourse = new creditCourse();
            creditCourse('.')

            CreditCourse creditCourse = new CreditCourse();
            creditCourse.CourseTitle = "CS101";
            creditCourse.CreditHours = 6;
            creditCourse.Program = "Computer Science";
            creditCourse.EnrollStudent("Tom Thumb");

            float GPA = creditCourse.CalculateGPA(98.5F);
            Console.WriteLine("Tom Thumb has a GPA of {0} in course {1}.", GPA, creditCourse.CourseTitle);

            NoncreditCourse nonCreditCourse = new NoncreditCourse();
            nonCreditCourse.CourseTitle = "Introduction to Excel";
            char grade = nonCreditCourse.CalculateGrade(87.0F);
            Console.WriteLine("Tom also received a {0} in {1}", grade, nonCreditCourse.CourseTitle);

            creditCourse newCreditCourse = new creditCourse();
            Console.WriteLine(newCreditCourse.CourseTitle);
            creditCourse newCreditCourseTwo = new creditCourse("CS102", 6, "Computer Science");
            Console.WriteLine(newCreditCourseTwo.CourseTitle);
        }

    }
    class Course
    {
        private string courseTitle;
        private int creditHours;
        private string program;

        public string CourseTitle
        {
            get { return courseTitle; }
            set { courseTitle = value; }
        }

        public int CreditHours
        {
            get { return creditHours; }
            set { creditHours = value; }
        }

        public string Program
        {
            get { return program; }
            set { program = value; }
        }

        public void EnrollStudent(string studentName)
        {

        }

        public virtual float CalculateAverage(float[] arrGrades)
        {
            float avg = 0;
            return avg;
        }
    }
    class creditCourse : Course
    {
        public override float CalculateAverage(float[] arrGrades)
        {
            return base.CalculateAverage(arrGrades);float[] arrGrades)
                {
                float avg = 0;
                float sum = 0;
                int numGrades = arrGrades.Count();
                foreach (float grade in arrGrades)
                {
                    sum = sum + grade;
                }
                avg = sum / numGrades;
                return avg;
            }
        }
        public float CalculateGPA(float grade)
        {
            char letterGrade;
            float gradePoints = 0.0F;

            if (grade >= 90)
            {
                letterGrade = 'A';
            }
            else if (grade >= 80 && grade <= 89)
            {
                letterGrade = 'B';
            }
            else if (grade >= 70 && grade <= 79)
            {
                letterGrade = 'C';
            }
            else if (grade >= 66 && grade <= 69)
            {
                letterGrade = 'D';
            }
            else
            {
                letterGrade = 'F';
            }

            switch (letterGrade)
            {
                case 'A':
                    gradePoints = 4.0F;
                    break;
                case 'B':
                    gradePoints = 3.0F;
                    break;
                case 'C':
                    gradePoints = 2.0F;
                    break;
                case 'D':
                    gradePoints = 1.0F;
                    break;
            }

            return gradePoints;
        }
        public creditCourse()
        {
            this.CourseTitle = "";
            this.CreditHours = 0;
            this.Program = "";
        }

        public creditCourse(string title, int credits, string program)
        {
            this.CourseTitle = title;
            this.CreditHours = credits;
            this.Program = program;
        }


    }
    class NoncreditCourse : Course
    {



    }
}