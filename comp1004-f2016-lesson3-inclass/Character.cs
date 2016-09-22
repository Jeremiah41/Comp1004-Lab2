using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace comp1004_f2016_lesson3_inclass
{
    public class Character
    {

        /**
         * PUBLIC PEROPERTY 
         */ 
        public string Strength
        {
            get
            {
                return this._Strength();
            }

            set
            {
                this.Strength = value;
            }
        }

        /**
         * PRIVATE INSTANCE VARS
         */

        private String _Strength()
        {
            throw new System.NotImplementedException();
        }
    }
}