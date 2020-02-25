using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsThe_Encryptor
{
    class SamlingChiper : ICipher
    {
        /// <summary>
        /// en lista med chipers
        /// </summary>
       private List<Chiper> samlingLista = new List<Chiper>();

        /// <summary>
        /// en metod som kallar på alla chipers i listan samlingslista som används och decryptar dem.
        /// </summary>
        /// <param name="input"></param>
        /// <returns> returnerar input</returns>
        public string Decrypt(string input)
        {
            for (int i = samlingLista.Count - 1; i >= 0; i--)
            {

                input = samlingLista[i].Decrypt(input);
            }
            return input;
        }

        /// <summary>
        /// en metod som kallar på alla chipers i listan samlingslista som används och encrypterar dem.
        /// </summary>
        /// <param name="input"></param>
        /// <returns> returnerar input</returns>
        public string Encrypt(string input)
        {
            for (int i = 0; i < samlingLista.Count; i++)
            {
                input = samlingLista[i].Encrypt(input);
            }
            return input;
        }

        /// <summary>
        /// lägger till chipers i listan samlingslista.
        /// </summary>
        /// <param name="c"></param>
        public void Add(Chiper c)
        {
            samlingLista.Add(c);
        }

        /// <summary>
        /// tar bort chipers i listan samlingslista.
        /// </summary>
        /// <param name="c"></param>
        public void Remove(Chiper c)
        {
            samlingLista.Remove(c);
        }



    }
}
