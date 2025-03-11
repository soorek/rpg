using rpg.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Player actor = new Player("Eblan", 100, 100, 1);
        for (int i = 0; i < 30; i++) 
        {

            actor.ShowInfo();
            actor.AddExp(150);
        }
    }
}