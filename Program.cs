using System;
using System.Speech.Synthesis;

namespace chatbox_cybersecurity_00
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "CyberSecurity Awareness Bot";
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Display ASCII Art
            DisplayAsciiArt();


            // Voice Greeting
            synth.Speak("Hello!" +
                " Welcome to the Double O Chatbox Cybersecurity Awareness Bot!" +


                " Im here to bring awareness and help you stay protected online." +
                " How can i help you ");



            // Text Greeting
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("======================================================");
            Console.WriteLine("Welcome to the 00 CyberSecurity Awareness Chatbot!");
            Console.WriteLine("======================================================");
            Console.ResetColor();


            // Get user name
            Console.Write("\nEnter your name: ");
            string userName = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.WriteLine("Name cannot be empty. Please enter a valid name.");
                userName = Console.ReadLine();
            }

            Console.WriteLine($"\nHello, {userName}! How can I assist you today?");
            Console.WriteLine("Type 'help' to see available topics or 'exit' to quit.\n");

            // Chat Loop
            ChatLoop();
        }

        static void DisplayAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Blue;


            // ASCII Art Display 
            Console.WriteLine(@"



00

 _____       _               _____                      _ _             ___                                              
/  __ \     | |             /  ___|                    (_) |           / _ \                                             
| /  \/_   _| |__   ___ _ __\ `--.  ___  ___ _   _ _ __ _| |_ _   _   / /_\ \_      ____ _ _ __ ___ _ __   ___  ___ ___  
| |   | | | | '_ \ / _ \ '__|`--. \/ _ \/ __| | | | '__| | __| | | |  |  _  \ \ /\ / / _` | '__/ _ \ '_ \ / _ \/ __/ __| 
| \__/\ |_| | |_) |  __/ |  /\__/ /  __/ (__| |_| | |  | | |_| |_| |  | | | |\ V  V / (_| | | |  __/ | | |  __/\__ \__ \ 
 \____/\__, |_.__/ \___|_|  \____/ \___|\___|\__,_|_|  |_|\__|\__, |  \_| |_/ \_/\_/ \__,_|_|  \___|_| |_|\___||___/___/ 
        __/ |                                                  __/ |                                                     
       |___/                                                  |___/                                                      
 _____ _           _                                                                                                     
/  __ \ |         | |                                                                                                    
| /  \/ |__   __ _| |__   _____  __                                                                                      
| |   | '_ \ / _` | '_ \ / _ \ \/ /                                                                                      
| \__/\ | | | (_| | |_) | (_) >  <                                                                                       
 \____/_| |_|\__,_|_.__/ \___/_/\_\                                                                                      
                                                                                                                                                                                                                                                  \|___|/      
     ");
            Console.ResetColor();







        }

        static void ChatLoop()
        {
            while (true)
            {
                Console.Write("\nYou: ");
                string userInput = Console.ReadLine().ToLower();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Bot: Please enter a valid input.");
                    continue;
                }

                if (userInput == "exit")
                {
                    Console.WriteLine("Bot: Goodbye! Stay safe online.");
                    break;
                }

                // get user input here



                if (userInput.Contains("help"))
                {
                    Console.WriteLine("Bot: You can ask me about:");
                    Console.WriteLine(" - Password safety");
                    Console.WriteLine(" - Phishing scams");
                    Console.WriteLine(" - Safe browsing tips");
                }
                else if (userInput.Contains("how are you"))
                {
                    Console.WriteLine("Bot: I'm just a bot, but I'm here to help you with cybersecurity!");
                }
                else if (userInput.Contains("what's your purpose"))
                {
                    Console.WriteLine("Bot: My purpose is to educate users about cybersecurity threats and safe online practices.");
                }
                else if (userInput.Contains("password"))
                {
                    Console.WriteLine("Bot: Use strong, unique passwords with a mix of letters, numbers, and symbols.");
                    Console.WriteLine(" - Never reuse passwords.");
                    Console.WriteLine(" - Enable two-factor authentication (2FA).");
                }
                else if (userInput.Contains("phishing"))
                {
                    Console.WriteLine("Bot: Be cautious with emails or messages that ask for personal information.");
                    Console.WriteLine(" - Check the sender's email address.");
                    Console.WriteLine(" - Do not click on suspicious links.");
                    Console.WriteLine(" - Report phishing attempts.");
                }
                else if (userInput.Contains("safe browsing"))
                {
                    Console.WriteLine("Bot: Always use HTTPS websites for transactions.");
                    Console.WriteLine(" - Keep your browser and antivirus software updated.");
                    Console.WriteLine(" - Avoid downloading files from untrusted sources.");
                }
                else
                {
                    Console.WriteLine("Bot: I didn't quite understand that. Could you rephrase?");
                }
            }
        }
    }
}
