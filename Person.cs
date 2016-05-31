using System;

namespace COMP123_S2016_Lesson3
{
    class Person
    {
        #region Fields
        // PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++
        private string _name;
        private int _age;
        #endregion

        #region Properties

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++

        /**
         * This is a property for our _name field
         * 
         * @property {string} Name
         */
        #region Public String Name (get/set)
        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            }
        }
        #endregion
        /*
         * <summary>
         * This is a public property Age(face) for our private _age(behindtheface) field
         * </summary>
         * Property int Age
         */
        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }
        #region getters and setters example
        //Getters 
        // public string getName()
        //{
        //  return _name;
        //}
        //Setters
        //public void setName(string name)
        //{
        //   this._name = name;
        // }
        #endregion

        #endregion
        /**
         * This is the constructor for the Person class 
        * @constructor Person
        */
        #region Constructors
        public Person()
        {
            this._name = "Tom";
        }

        /**
        * This is a consructor that takes name as a parameter and passes 
        * it to the _name private instance variable
        * 
         * @constructor Person
         * @param {string} name
         */

        public Person(string name, int age)
        {
            this._name = name;
        }
        /**<summary>
         * This method outputs the _name value to the console
         </summary>*/
        #endregion
        #region Public Methods
        public void SaysHello()
        {
            Console.WriteLine(this._name + " says hello");
        }

        public void ShowAge()
        {
            Console.WriteLine(this._name + " is " +this._age + " years old.");  //"Tom is 47 years old"
        }
        #endregion
    }
}
