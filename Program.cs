namespace Number02;

class Program
{
    
        class TrafficLightSimulator
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Please enter the seconds elapsed in a 30-second cycle:");
                string input = Console.ReadLine();
                int secondsElapsed = int.Parse(input);
                
                string currentColor = GetTrafficLightColor(secondsElapsed);
                
                Console.WriteLine("The current traffic light color is: " + currentColor);
            }

            static string GetTrafficLightColor(int secondsElapsed)
            {
                // Define the duration of each light in seconds
                int greenDuration = 15;
                int yellowDuration = 3;
                int redDuration = 12;

                // Calculate the current color based on the seconds elapsed
                if (secondsElapsed < greenDuration)
                {
                    return "Green";
                }
                else if (secondsElapsed < greenDuration + yellowDuration)
                {
                    return "Yellow";
                }
                else
                {
                    return "Red";
                }
            }
        }

    }
