using System;

namespace ClassActivity4
{
    interface InterfaceStudent
    {
        int ID { get; set; }
        short Credits { get; set; }
        bool Graduated { get; }
    }

    //Instance method is name.
    //Properties are id, credits, and graduated
    class Student : InterfaceStudent
    {
        public string name;

        //ID is either a 8-digit or an 9-digit number
        public int id;
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                if (value <= 999999999 && value >= 10000000)
                {
                    id = value;
                }
                else
                {
                    id = 0;
                }
            }
        }

        public short credits;

        public short Credits
        {
            get
            {
                return credits;
            }
            set
            {
                if (value <= 200 && value >= 0)
                {
                    credits = value;
                }
            }
        }
        public bool graduated;

        public bool Graduated
        {
            get
            {
                if (credits < 120)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public short AddCredits(short credits_add)
        {
            credits += credits_add;
            return credits;
        }
    };

    // Indexer CourseNames<T>
    class CourseNames<T>
    {
        private T[] course = new T[50];

        public T this[int i]
        {
            get { return course[i]; }
            set { course[i] = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var Anthony = new Student();
            Anthony.name = "Anthony";
            Anthony.ID = 278000000;
            Anthony.Credits = 114;
            bool grad_status = Anthony.Graduated;
            Anthony.AddCredits(3);
            Anthony.AddCredits(4);
            grad_status = Anthony.Graduated;

            var CourseNames = new CourseNames<string>();
            CourseNames[0] = "CSCI 12700";
            CourseNames[1] = "CSCI 15000";
            CourseNames[2] = "CSCI 16000";
            CourseNames[3] = "CSCI 27500";
        }
    }
}
