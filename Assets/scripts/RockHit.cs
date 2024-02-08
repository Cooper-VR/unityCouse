using UnityEngine;

public class RockHit : ObjectHit
{
    public override void OnHit(string tag)
    {
        if (tag == "Player")
        {
            AddToScore();


            Destroy(gameObject);
        }
    }

    private void AddToScore()
    {

    }
}
