using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    class Validation
    {
        public bool GetValidate(string i)
        {
            bool cont = true;
            while (cont)
            {
                if (i == "n" || i == "N")
                {
                    Console.WriteLine("\nThanks for the chat.  Have a great day!");
                    return false;
                }
                else if (i == "y" || i == "Y")
                {
                    return true;
                }
            }
            return true;
        }
        public bool Input { get; set; }
    }
}
