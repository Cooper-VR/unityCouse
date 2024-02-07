public class playerDeath : ObjectHit
{
    public override void OnHit()
    {
        //save the score
        MenuManager.ToMainMenu();
    }
}
