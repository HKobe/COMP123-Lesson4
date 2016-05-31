using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson3
{
    namespace COMP123_S2016_Lesson3
    {
        /**
         * This class is the "driver" class for our Program
          * 
          * @class Program
          */
        public class Program
        {
            /**
             * the main method for our driver class Program
             * 
             * @method Main
             * @param {sting[]} args
            */
            public static void Main(string[] args)
            {
                #region  New instances of person class
                // create a new instance of the Person class
                Person person = new Person("Tom");

                Console.WriteLine(person.Name);

                // set a value in the Name property of the Person class
                person.Name = "Hassan";
                person.Age = 47;

                // get the Name value and print to console
                Console.WriteLine(person.Name);

                person.SaysHello();
                person.ShowAge();
                #endregion
                #region New instances of Student Class
                //Tommy and Tom are instances of the stuent and teacher class derived from the person class
                Teacher Tommy = new Teacher("Tommy", 22, "T21542563");

                Tommy.SaysHello();

                Console.WriteLine();

                Tommy.Teaches();
                #endregion
                Tommy.Courses.Add(new Course("COMP123", "PROGRAMMING2"));

                // here is a simple comment
            }
        }
    }
}

  