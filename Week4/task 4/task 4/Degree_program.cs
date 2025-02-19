using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    internal class Degree_program
    {
        public string Degree_name;
        public int Duration;
        public int Seats;
        public int No_Of_Subjects;
        public string Sub_Code;
        public string Sub_Type;
        public int Credit_Hours;
        public int Sub_Fees;
        public Degree_program(string degree_name , int duration , int seats , int no_of_subject , string sub_code , string sub_type , int credit_hours , int sub_fees)
        {
            Degree_name = degree_name;
            Duration = duration;
            Seats = seats;
            No_Of_Subjects = no_of_subject;
            Sub_Code = sub_code;
            Sub_Type = sub_type;
            Credit_Hours = credit_hours;
            Sub_Fees = sub_fees;

        }
    }
}
