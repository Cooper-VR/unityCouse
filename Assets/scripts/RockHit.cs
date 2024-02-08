using UnityEngine;

public class RockHit : ObjectHit
{
    public override void OnHit()
    {

        AddToScore();
        Destroy(gameObject);
    }

    private void AddToScore()
    {

    }
}
