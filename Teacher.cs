using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson3
{
    /*<summary>
     * The teacher class is derived from the Person Class
     </summary>
     @class teacher
     @extends Person
     */
    class Teacher:Person
    {
        //here is the private instance variables
        private string _employeeID;
        //Public Properties
        public string EmployeeID
        {
            get
            {
                return this._employeeID;
            }
            set
            {
                this._employeeID = value;
            }
        }
        //Constructor Section
        /*
         <summary>
         this constructor mehtods takes three params: name, age, employeeID
         </summary>
         @Constructor Teacher
         @param string name
         @param int age
         @param string employeeID
         */
        public Teacher(string name, int age, string employeeID)
            :base(name, age)
        {
            this.EmployeeID = employeeID;
        }
        //Public  Methods
        public void Teaches()
        {
            Console.WriteLine(this.Name + "teaches.");
        }
    }
}
