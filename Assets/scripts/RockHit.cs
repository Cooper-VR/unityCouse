using TMPro;
using UnityEngine;
// INHERITANCE
public class RockHit : ObjectHit
{
    // ABSTRACTION
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
        int score = int.Parse(FindObjectOfType<TMP_Text>().text);

        score += 100;

        FindObjectOfType<TMP_Text>().text = score.ToString();
    }
}
