using System;
using Students_Management;

namespace Assignment
{
    class Student : IStudent
    {
        public Student()
        {
        }

        public Student(string fullName, string dateofBirth, string native, string @class, string phoneNo, int mobile)
        {
            FullName = fullName;
            ID = Program.students.Count;
            DateofBirth = dateofBirth;
            Native = native;
            Class = @class;
            PhoneNo = phoneNo;
            Mobile = mobile;
        }

        public string FullName { get; set; }

        public int ID { get; set; }

        public string DateofBirth { get; set; }

        public string Native { get; set; }

        public string Class { get; set; }

        public string PhoneNo { get; set; }

        public int Mobile { get; set; }

        public void Display()
        {
            Console.WriteLine($"Full name: {FullName} - ID: {ID} - Date of birth: {DateofBirth} - Native: {Native} - Class: {Class} - Phone no: {PhoneNo} - Mobile: {Mobile}");
        }
    }
}
