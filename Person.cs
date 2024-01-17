using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_FieldsProperties_DavidAbarca
{
    public class Person
    {
        // Private field: Encapsulates the data to prevent direct external access
        private string _name;

        public string Name
        {

            get { return _name; } // Getter: Returns the value of _name
            set 
            {
                if (!string.IsNullOrEmpty(value))
                    _name = value;
                else
                    throw new ArgumentException("Name cannot be null or empty");
            
            
            
            
            } // Setter: Assigns a value to _name
        }

        public string ReadOnlyName
        {
            get { return _name; }
        }

        public string WriteOnlyName
        {
            set { _name = value; }
        }




    }
}
