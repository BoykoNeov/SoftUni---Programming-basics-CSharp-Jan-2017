using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salt_and_pepper
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong manja = ulong.Parse(Console.ReadLine());
            string consoleRead = "";

            for  (;consoleRead != "end";)
            {
                consoleRead = Console.ReadLine();
                if (consoleRead == "end") break;
                string[] commands = consoleRead.Split(' ');

                if (int.Parse(commands[1]) != 0)
                {
                    int vsqkoKoeChislo = int.Parse(commands[1]);


                    if (commands[0] == "salt")
                    {
                        ulong salt = 1;
                        for (int pov = 0; pov < 64; pov += vsqkoKoeChislo)
                        {
                            salt = salt << vsqkoKoeChislo;
                            salt = salt + 1;
                        }
                        salt = ~salt;
                                                                                              //  string salt_string = Convert.ToString((long)salt, 2);
                                                                                              //  Console.WriteLine($"salt: {salt_string}");
                        manja = manja & salt;
                    }

                    if (commands[0] == "pepper")
                    {
                        ulong salt = 1;
                        for (int pov = 0; pov < 64; pov += vsqkoKoeChislo)
                        {
                            salt = salt << vsqkoKoeChislo;
                            salt = salt + 1;
                        }
                        manja = manja | salt;
                    }
                }  
            }
            Console.WriteLine(manja);
            



        }
    }
}
