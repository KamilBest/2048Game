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
        public bool isZeroValue()
        {
            return (value == 0);
              
        }

        /**
        Set zero value to cell (reset cell).
        */
        public void setZeroValue()
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

        /**
        Set givenValue to current cell.
        */
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
