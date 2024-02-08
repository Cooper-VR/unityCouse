using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHit : ObjectHit 
{
    public override void OnHit(string tag)
    {
        if (tag == "Rock")
        {
            Destroy(gameObject);
        }
    }
}
