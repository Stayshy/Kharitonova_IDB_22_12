
using UnityEngine;
using UnityEngine.UI;

public class CollisionCounter : MonoBehaviour
{
    public Text counterText;
    private int collisionCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        collisionCount++;
        UpdateCounterText();
    }

    private void UpdateCounterText()
    {
        counterText.text = "Collision Count: " + collisionCount.ToString();
    }
}