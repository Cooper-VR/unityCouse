public class playerDeath : ObjectHit
{
    public override void OnHit(string tag)
    {
        if (tag == "rock")
        {
            MenuManager.ToMainMenu();

        }
        
    }
}
