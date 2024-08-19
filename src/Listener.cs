namespace Game.Listener;

using System.Collections;
using Commands.Help;

public class Listener{
    public string listener(){
        return Console.ReadLine().ToLower();
    } 

    public void executor(string cmd){
        
    }
}
