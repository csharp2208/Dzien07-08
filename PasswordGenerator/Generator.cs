using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{

    enum PasswordTypes
    {
        DIGITS,         // tylko cyfr
        DIGITS_ALFA,    // cyfry i znaki alfabetu
        ALL             // wszystkie dostepne znaki
    }

    class Generator
    {
        List<String> passwordHistory = new List<string>();
        Random rnd = new Random( Guid.NewGuid().GetHashCode() );
        String availChars;

        public List<String> Generate(int passLength, int passCount, 
            PasswordTypes type )
        {
            List<String> passwordList = new List<string>();
            switch (type)
            {
                case PasswordTypes.DIGITS:
                    availChars = "0123456789";
                    break;
                case PasswordTypes.DIGITS_ALFA:
                    availChars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                    break;
                case PasswordTypes.ALL:
                    StringBuilder sb = new StringBuilder();
                    for (int i = 33; i <= 126; i++)
                    {
                        sb.Append((char)i);
                    }
                    availChars = sb.ToString();
                    break;
                default:
                    return null;                    
            }

            for (int i = 0; i < passCount; i++)
            {
                String pass;
                while (true)
                {
                    pass = OnePass(passLength);
                    if (passwordHistory.IndexOf(pass) == -1) 
                        break; 
                }
                passwordHistory.Add(pass);
                passwordList.Add(pass);
            }
            return passwordList;
        }
    
        private String OnePass(int passLength)
        {
            // generowanie hasła o dług. N znaków
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < passLength; i++)
            {
                sb.Append(availChars[rnd.Next(0, availChars.Length)]);
            }
            String password = sb.ToString();
            return password; 
        }
    }
}
