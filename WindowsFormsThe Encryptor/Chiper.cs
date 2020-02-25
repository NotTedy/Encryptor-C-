using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsThe_Encryptor
{
    /// <summary>
    /// denna abstrakta klass deklarerar metoder och egenskaper som underklaserna ärver från.
    /// </summary>
    abstract class Chiper : ICipher
    {
        public abstract string Encrypt(string input);
        public abstract string Decrypt(string input);

        public string Name { get; set; }

        public Chiper(string _name)
        {
            Name = _name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
