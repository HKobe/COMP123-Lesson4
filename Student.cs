using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMP123_S2016_Lesson3;

namespace COMP123_S2016_Lesson3
{
    /*
     <summary>
     This is the student class.  It is derived from the person class
     </summary>
     @class Student
     @extend Person
     */
    class Student:Person //Student IS A Person
    {
        #region Private Instance
        private string _studentID;
        private List<Course> _courses = new List<Course>();
        #endregion
        #region Public Instance
        /*<summary>
         This property, StudentID, includes a getter and setter for the private instance variable _studentID */
        #endregion

        public string StudentID

        {
            get
            {
                return this._studentID;
            }
            set
            {
                this._studentID = value;
            }
            #region Constrcutos
            
            #endregion
        }
        public List<Course> Courses
        {
            get
            {
                return this._courses = Courses;
           }
        }
        /*
         <summary>
         This constructor takes three parameters: name, age, studentID
         </summary>
         @Class Student
         @extends Person
         @param string name
         @param int age
         @param string studentID
        */
    }
    public Student(string name, int age, string studentID)
        :base(name, age)
     {

    }
     
    #region Public Methods
    /*<summary>
     * This method enables the studies behaviour for the student
     </summary>
     @method stuies
     @returns void
     */
     public void Studies ()
    {
        Console.WriteLine(this.Name + "studies");
    }
    #endregion
}
