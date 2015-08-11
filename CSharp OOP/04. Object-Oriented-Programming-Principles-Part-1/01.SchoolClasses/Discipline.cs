
namespace _01.SchoolClasses
{
    using System;

    class Discipline : ICommentable
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public string Name 
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int NumberOfLectures
        {
            get { return this.numberOfLectures ;}
            set { this.numberOfLectures = value; }
        }

        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
            set { this.numberOfExercises = value; }
        }

        public string Comment { get; set; }

        public override string ToString()
        {
            return String.Format("  Discipline name:{0}\n  Number of lectures: {1}\n  Number of exercises: {2}",
                this.Name,this.NumberOfLectures,this.NumberOfExercises);
        }
    }
}
