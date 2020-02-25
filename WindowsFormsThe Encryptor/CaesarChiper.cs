using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsThe_Encryptor
{
    class CaesarChiper : Chiper
    {
        
        /// <summary>
        /// en egenskap till steg
        /// </summary>
        private int Steg { get; set; }

        /// <summary>
        /// en konstruktor som säger hur många steg som cecarchipern ska gå.
        /// </summary>
        /// <param name="_nyckel"></param>
        public CaesarChiper(int _nyckel) : base("CaesarChiper " + _nyckel)
        {
            Steg = _nyckel;
        }

        /// <summary>
        /// använde sig av en tomsträng och itererar över inputen, använder sig av GetChiper metoden.
        /// Getchiper metoden tar en char av inputen och alla bokstaver i alfabetet minus antalet steg.
        /// </summary>
        /// <param name="input"></param>
        /// <returns> tomsträng </returns>
        public override string Decrypt(string input)
        {
            string tomSträng = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                tomSträng += GetChiperChar(input[i], 26 - Steg);
            }
            return tomSträng;
        }

        /// <summary>
        /// använde sig av en tomsträng och itererar över inputen, använder sig av GetChiper metoden.
        /// Getchiper metoden tar en char av inputen och antalet steg.
        /// </summary>
        /// <param name="input"></param>
        /// <returns> tomsträng</returns>
        public override string Encrypt(string input)
        {
            string tomSträng = string.Empty;
            for(int i = 0; i < input.Length; i++)
            {
                tomSträng += GetChiperChar(input[i], Steg);
            }
            return tomSträng;
            
        }

        /// <summary>
        /// Denna metod tar emot en bokstav och ett angivet antal steg. 
        /// Den avgör sedan först om det är en bokstav eller ej. specialtecken returneras.
        /// konstrollerar om en bokstav är en versal eller ej. utför beräkning gentemot alfabetet 26.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="steg"></param>
        /// <returns></returns>
        private char GetChiperChar(char c, int steg)
        {
            List<char> specialCharacters = new List<char>() { 'å', 'ä', 'ö'};

            if (!char.IsLetter(c) || specialCharacters.Contains(char.ToLower(c)))
            {
                return c;
            }

            char d = char.IsUpper(c) ? 'A' : 'a';
            return (char)((((c + steg) - d) % 26) + d);
        }
    }
}
