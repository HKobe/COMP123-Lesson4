using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson3
{
    /*
     * <summary> This is the course class - we're using this as a custom data type for our teacher and student classes </summary>
     * @class Course
     *       
     */
    class Course
    {
        #region Private and Public variables
        private string _code;
        private string _description;

        //Public
        public string Code
        {
           get {
                return this._code;
            }
            set
            {
                this._code = value;
               
            }
            
        }
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;

            }

        }
        #endregion
        #region Constructor(s)
        #endregion
        /*
         * <summary>This constructor takes two params:Code, Description</summary>
         * @Contstructor Course
         * @params: string code, string description
         */
        public Course(string code, string description)
        {
            this.Code = code;
            this.Description = description;
        }
    }
}
