namespace Synapse_X_Remake
{
    public static class Logger
    {
        public static void Init()
        {
            AllocConsole();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "Winky Executor (dbgcs)";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"                                            
                                            -                       
                                         ---=                       
             ++====                     -=--                        
             #*+=+=*++               --+=--                         
              =----=+**+==#+*+**+******+==-                         
              +==-:-==*#*%%#+%#++++%%**==-=-                        
                ===+-+==+*#%#%%++*+=#**+=--:                        
                *+=+--++=++++*%*#*#=#+#=-==--                       
                **=*=+=-+*+#+-%#=#*+%=%+:++=-                       
                *%*#+==::=+*=--*==:-+=+--+%=:=                      
                +***+**+==%#%-%*-:..:-+=%+@-++=                     
                +++*+%*=:=%@%:+*-....++=*@@:=#=                     
               +*+***+-=*#:-+*+**=:..-*#-#%*=++                     
              ##+*+####+#**=+++**-:...=-++##%*=                     
             #%#+#*++++*#%#%*-:.:-:::-...-+*+==                     
            ##*#*+*+-*##**===.....-+*.....-=*=                      
            ###**++***=++-::.:::::-=-:..::=--=-:                    
            ######*+**++=:.:::---:::-:::.:::=+=                     
           #####**%+=---....::::--:::::.:::=+*=                     
           ######*#*#+:-:::::..:::::::::::-+++=                     
        @@@%##*##**#***+--:::.:::......:-:++===                     
       @@@@%##%#*##+*#+=+-:..:........:+=+==-==                     
      @@@@@ #+*****+*+***++===-:=-...-=-=-=+*+                      
           #*##**++##+*%##+**#%#*+=..---:..:                        
           ###*+**##+*#+##=-:....:++=-:=.:...                       
              #%#*****+#=::......:                                  
                      *=-......--                                   
                        -.:.:-                                           ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"
 __      __.__        __            ___________                            __                
/  \    /  \__| ____ |  | _____.__. \_   _____/__  ___ ____   ____  __ ___/  |_  ___________ 
\   \/\/   /  |/    \|  |/ <   |  |  |    __)_\  \/  // __ \_/ ___\|  |  \   __\/  _ \_  __ \
 \        /|  |   |  \    < \___  |  |        \>    <\  ___/\  \___|  |  /|  | (  <_> )  | \/
  \__/\  / |__|___|  /__|_ \/ ____| /_______  /__/\_ \\___  >\___  >____/ |__|  \____/|__|   
       \/          \/     \/\/              \/      \/    \/     \/                          ");
            Console.ForegroundColor = ConsoleColor.White;
            Log("INFO", "winky exec on top", ConsoleColor.Cyan);
        }

        public static void Log(string tag, string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write($"[{DateTime.Now:HH:mm:ss}] ");
            Console.ForegroundColor = color;
            Console.Write($"[{tag}]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($" {message}");
        }

        public static void Info(string message) => Log("INFO", message, ConsoleColor.Cyan);
        public static void Success(string message) => Log("OK", message, ConsoleColor.Green);
        public static void Error(string message) => Log("ERROR", message, ConsoleColor.Red);
        public static void Script(string message) => Log("SCRIPT", message, ConsoleColor.Yellow);
        public static void Attach(string message) => Log("ATTACH", message, ConsoleColor.Magenta);

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
    }
}