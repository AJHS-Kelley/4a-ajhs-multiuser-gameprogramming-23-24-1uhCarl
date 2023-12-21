// Carlton Brinkley, Game Method, v0.01
using Stystem;
class BasketballGame 
{
    static void Main()
    {
        int totalShots = 5 ;
        int shotsMade = 0:

        Console.Writeline("Welcome to the Basketball Shooting Game!");
        Console.Writeline("You have " + totalShots + "Shots. Good luck!");
        for (int i = 0; i < totalShots; i++)
        
            Console.Writeline("Press 'S' to shoot.")
            ConsoleKeyInfo key = Console.Readkey();
            if (key.KeyChar == 'S'  key.KeyChar == 's')
    }   
                Random random = new Random();
                int shotResult = random.Next (0, 2); // 0 represents a miss, 1 represents a make
                if (shotResults == 1)
                {
                    Console.WriteLine("\nGreat shot! You made it");
                    shotsMade++;
                }
                else
                {
                    Console.WriteLine("\n0ops! You missed this shot."):
                }
             }
            else
            {
               Console.WriteLine("\nInvalid input. Press 'S' to shoot.");
               i--; // Decrement the counter to repeat this shot.
            }
        Console.WriteLine("\nGame Over!");
        Console.WriteLine("You made " + shotsMade + "out of " + totalShots + "shots");
        Console.ReadLine(); // Keeps the console window open until Enter is pressed.
                                                                                
                                                                        
            
    
            
                
                


        
    
    
    
}