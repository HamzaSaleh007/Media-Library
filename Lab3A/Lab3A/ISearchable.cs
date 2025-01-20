using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
    /*
   Interface: ISearchable.cs
   Author:    Hamza Saleh,000887384
   Date:      October 31,2023

   Purpose: This interface has one method that classes making use of must
            implement. 

            This code is not to be altered.
 */

    /// <summary>
    /// The class implementing the Search() method will be assumed to
    /// use a string search key as a parameter and return a boolean
    /// value to indicate if that key was successfully found.
    /// </summary>

    interface ISearchable
    {
        bool Search(string key);
    }

}
