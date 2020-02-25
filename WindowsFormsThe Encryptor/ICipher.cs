using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsThe_Encryptor
{
    interface ICipher
    {
        /// <summary>
        /// de här metoderna använd i alla chiperklasser.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        string Encrypt(string input);
        string Decrypt(string input);
    }
}
