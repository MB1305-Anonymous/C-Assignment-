namespace Number03;
 using System;
 using System.Linq;

class Program
{
      static void Main()
            {
                Console.WriteLine("Please enter a password to check its strength:");
                string password = Console.ReadLine();
                string strength = CheckPasswordStrength(password);
                Console.WriteLine($"The password strength is: {strength}");
            }

            static string CheckPasswordStrength(string password)
            {
                int length = password.Length;
                bool hasLower = password.Any(char.IsLower);
                bool hasUpper = password.Any(char.IsUpper);
                bool hasDigit = password.Any(char.IsDigit);
                bool hasSpecial = password.Any(c => !char.IsLetterOrDigit(c));

                if (length >= 8 && hasLower && hasUpper && hasDigit && hasSpecial)
                {
                    return "Your Password is Strong! ";
                }
                else if (length >= 6 && ((hasLower && hasUpper) || (hasLower && hasDigit) || (hasUpper && hasDigit)))
                {
                    return "Your Password Is Medium in Strength";
                }
                else
                {
                    return "Your Password Is Too Weak :(";
                }
            }
        }

