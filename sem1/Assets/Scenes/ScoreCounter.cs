using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Text scoreText;
    private int score;

    private void Start()
    {
        score = 0;
        UpdateScoreText();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Увеличиваем счетчик и обновляем текстовый объект
        score--;
        UpdateScoreText();
    }
    private void OnCollisionExit(Collision collision)
    {
        // Увеличиваем счетчик и обновляем текстовый объект
        score--;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}