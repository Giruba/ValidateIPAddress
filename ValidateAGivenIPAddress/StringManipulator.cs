using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValidateAGivenIPAddress
{
    static class StringManipulator
    {

        public static void ValidateIPV4Address(string IPV4address)
        {

            if (string.IsNullOrEmpty(IPV4address))
            {
                Console.WriteLine("Entered string is NULL!");
            }
            else
            {
                IPV4address = IPV4address.Trim();
                if (string.IsNullOrEmpty(IPV4address))
                {
                    Console.WriteLine("Entered string is NULL!");
                }
                else
                {
                    if (IPV4address.Any(c => char.IsDigit(c)))
                    {
                        DotIndices dotIndices = CountDots(IPV4address);
                        if (dotIndices.GetFirstString() != null && dotIndices.GetSecondString() != null
                            && dotIndices.GetThirdString() != null && dotIndices.GetFourthString() != null)
                        {
                            dotIndices.SetFirstValidation(ValidateStringForIPRange(dotIndices.GetFirstString()));
                            dotIndices.SetSecondValidation(ValidateStringForIPRange(dotIndices.GetSecondString()));
                            dotIndices.SetThirdValidation(ValidateStringForIPRange(dotIndices.GetThirdString()));
                            dotIndices.SetFourthValidation(ValidateStringForIPRange(dotIndices.GetFourthString()));

                            if (dotIndices.GetFirstValidation() && dotIndices.GetSecondValidation()
                                && dotIndices.GetThirdValidation() && dotIndices.GetFourthValidated())
                            {
                                Console.WriteLine("-----------------------------------");
                                Console.WriteLine("Entered IPV4 address is valid!");
                            }
                            else
                            {
                                Console.WriteLine("-----------------------------------");
                                Console.WriteLine("Entered IPV4 address is not valid!");
                            }
                        }
                        else {
                            Console.WriteLine("Entered IP address is invalid (Format)!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("IP address should have numbers!");
                    }
                }
            }
        }

        public static DotIndices CountDots(string IPaddress)
        {
            DotIndices dotIndices = new DotIndices();
            int dotCount = 0;

            char[] charArray = IPaddress.ToCharArray();
            if (charArray.Length > 15)
            {
                Console.WriteLine("Maximum length of IP address can be only 15");
            }
            else
            {
                for (int i = 0; i < IPaddress.Length; i++)
                {
                    if (charArray[i] == '.')
                    {
                        if (dotCount == 3) {
                            Console.WriteLine("Invalid IPV4 address - Only 3 dots can be present in the IP address");
                            return dotIndices;
                        }
                        dotCount++;
                        if (dotIndices.GetFirstIndex() == 0)
                        {
                            dotIndices.SetFirstIndex(i);
                            dotIndices.SetFirstString(
                                IPaddress.Substring(0, i));
                        }
                        else
                        {
                            if (dotIndices.GetSecondIndex() == 0)
                            {
                                int firstIndex = dotIndices.GetFirstIndex();
                                dotIndices.SetSecondIndex(i);
                                dotIndices.SetSecondString(
                                    IPaddress.Substring(
                                        firstIndex+1,
                                        i-(firstIndex+1)));

                            }
                            else
                            {
                                int secIndex = dotIndices.GetSecondIndex();
                                dotIndices.SetThirdIndex(i);
                                dotIndices.SetThirdString(
                                    IPaddress.Substring(
                                        secIndex + 1,
                                        i-(secIndex+1)));
                            }
                        }

                    }
                }
                if (dotCount < 3)
                {
                    Console.WriteLine("Entered IP address is not valid!");
                    return dotIndices;
                }
                else {
                    dotIndices.SetFourthString(
                        IPaddress.Substring(dotIndices.GetThirdIndex()+1,
                        IPaddress.Length-(dotIndices.GetThirdIndex()+1)));
                }
            }
            return dotIndices;
        }

        public static bool ValidateStringForIPRange(String substring) {
            try
            {
                int number = int.Parse(substring);
                if (number < 0 || number > 255)
                {
                    Console.WriteLine("IP address number cannot be lesser than zero or greater than 255");
                    return false;
                }
                else if(number >= 0 && number <= 255){
                    Console.WriteLine(substring + " is validated!");
                    return true;
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }
            return false;
        }
    }
}
