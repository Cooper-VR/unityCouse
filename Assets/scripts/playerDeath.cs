// INHERITANCE

public class playerDeath : ObjectHit
{
    // ABSTRACTION
    public override void OnHit(string tag)
    {
        if (tag == "Rock")
        {
            MenuManager.ToMainMenu();

        }
        
    }
}
