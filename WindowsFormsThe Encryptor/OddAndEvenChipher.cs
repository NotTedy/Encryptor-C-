using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsThe_Encryptor
{
    class OddAndEvenChipher : Chiper
    {
        /// <summary>
        /// en konstruktor
        /// </summary>
        public OddAndEvenChipher() : base("OddAndEven")
        {

        }

        /// <summary>
        /// dekrypterar strängen
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public override string Decrypt(string input)
        {
            ///<summary>
            ///Skapar två nya "substrings"/nya strängar, en som heter odd och en som heter even. 
            ///Vi delar alltså upp vår "input string" till två strängar
            ///</summary>

            string odd = "";
            for (int i = 0; i < input.Length / 2; i++)
            {
                odd += input[i];
            }

            string even = "";
            for (int i = odd.Length; i < input.Length; i++)
            {
                even += input[i];
            }

            ///<summary>
            ///I count sparar vi ner den dekrypterade stringen
            ///</summary>

            string reCount = "";

            ///<summary>
            ///ifall even och odd är lika långa
            ///</summary>
            if (even.Length == odd.Length)
            {
                for (int i = 0; i < even.Length; i++)
                {
                    reCount += even[i];
                    reCount += odd[i];
                }
            }

            ///<summary>
            ///annars ifall even är längre
            ///</summary>
            else
            {
                for (int i = 0; i < even.Length; i++)
                {
                    reCount += even[i];
                    if (i < odd.Length)
                    {
                        reCount += odd[i];
                    }
                    else
                    {

                    }
                }
            }
            return reCount;
        }




        /// <summary>
        /// tar först alla udda indexpositioner av strängen input och sätter in dem i den tomma strängen count.
        /// Sen tar de alla jämna indexpositioner av strängen och sätter in dem i stängen conunt.
        /// </summary>
        /// <param name="input"></param>
        /// <returns> retunerar count </returns>
        public override string Encrypt(string input)
        {
            string count = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 != 0)
                {
                    count += input[i];
                }
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    count += input[i];
                }
            }
            return count;
        }
    }
}
