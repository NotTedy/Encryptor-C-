using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsThe_Encryptor
{
    class ReversalChiper : Chiper
    {
        /// <summary>
        /// en konstruktor
        /// </summary>
        public ReversalChiper() : base("ReversalChiper")
        {

        }

        /// <summary>
        /// ittererar bakläges igenom iputen och sparar indexpostionen från input till en tom sträng count.
        /// samma som encrypt.
        /// </summary>
        /// <param name="input"></param>
        /// <returns> count</returns>
        public override string Decrypt(string input)
        {
            string count = "";
            for (int i = input.Length; i-- > 0;)
            {
                count += input[i];
            }
            return count;
        }

        /// <summary>
        /// ittererar bakläges igenom iputen och sparar indexpostionen från input till en tom sträng count.
        /// samma somdecrypt.
        /// </summary>
        /// <param name="input"></param>
        /// <returns> count </returns>
        public override string Encrypt(string input)
        {
            string count = "";
            for (int i = input.Length-1; i >= 0; i--)
            {
                count += input[i];
            }
            return count;
        }
    }
}
