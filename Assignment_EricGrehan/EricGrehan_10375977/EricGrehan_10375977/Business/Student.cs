using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EricGrehan_10375977.DataAccess;

namespace EricGrehan_10375977
{
    class Student
    {
        static AddStudentClass data = new AddStudentClass();
        static  DeleteStudentClass deleteData = new DeleteStudentClass();
        static List<Student> student = new List<Student>();

        public int StudentNumber { get; set; }
        public string FirstName {get;set;}
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Phone{ get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }          //Drop down
        public string Course { get; set; }          //Drop down of at least 5 courses
        public string Level { get; set; }           //Either Post or Under Grad ------radio buttons

        public Student() { }

        public Student(int studentNumber, string firstName, string surName, string email,string phone,
             string addressLine1, string addressLine2, string city,
             string county, string course, string level)
        {
            StudentNumber = studentNumber;
            FirstName = firstName;
            SurName = surName;
            Email = email;
            Phone = phone;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            County = county;
            Course = course;
            Level = level;
        }
        /**********************************************************************************************/
        public void StudentaddtoDB()
        {
           
            data.addStudent(StudentNumber, FirstName, SurName, Email, Phone, AddressLine1, AddressLine2, City, County, Course, Level);
        }
       
        public static void ADDSTUDENT(int studentNumber, string firstName, string surName, string email, string phone,  string addressLine1, string addressLine2, string city, string county, string course, string level)
        {
            Student s = new Student(studentNumber, firstName, surName, email, phone,  addressLine1, addressLine2, city, county, course, level);
            student.Add(s);
            s.StudentaddtoDB();
        }
        /**********************************************************************************************/
        public void DeleteStudent(int studentNumber)
        {
            deleteData.DeleteStudent(studentNumber);
        }

       


    }
}
