using Game.Listener;
internal class main{ 
    static void Main(){
        // Main game execution point
        Console.WriteLine("Welcome to the ConsoleBasedRPG, you are currently at house\nPress H for help or S to start");
        string nextkey = Console.ReadLine().ToLower();
        if (nextkey == "s") {
            Console.WriteLine("Help will arrive soon");
        }
        Listener listener = new Listener();
        listener.listener(); 
    }
}
