using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    /**
    Single cell class
        Fields: value, fieldState
        Methods: getFieldState,setEmpty,setNotEmpty,setFirstValue, doubleValue,get Value, isEmpty
    */
    public class Cell
    {
        int value;
    
        /**
        Constructor, set cell empty on create.
        */
        public Cell()
        {
            this.value = 0;
        }

        /**
       Check whether fieldstate is empty
       */
        protected bool isEmpty()
        {
            if (value==0)
                return true;
            return false;
        }

        public void resetValue()
        {
            value = 0;
        }
        /**
     Set beginning value
         */
        public void setFirstValue()
        {
            value = 2;
        }
        public void setValue(int givenValue)
        {
            value = givenValue;
        }
        /**
      Get Value
          */
        public int getValue()
        {
            return value;
        }
        
        /**
        Double value
            */
        public void doubleValue()
        {
            value *= 2;
        }
    }
}
