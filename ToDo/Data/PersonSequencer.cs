using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Data
{
    /*
     Create a new class PersonSequencer in Data folder.
a. In PersonSequencer creates a private static int variable called personId.
b. 
d. Unit test PersonSequencer.
e. Commit changes.
    */

    public class PersonSequencer
    {
   //     Add a static method called nextPersonId that increment and return the next personId value.
   

        private static int personId;
        public static int NextPersonId(int personId)
        {
            
            personId = personId + 1;
            return personId;

        }

        //c.Add a static method called reset() that sets the personId variable to 0.
        public static int Reset(int personId)
        {
            personId = 0;
            return personId;

        }
    }
}
