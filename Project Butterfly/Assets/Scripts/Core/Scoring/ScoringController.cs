using TMPro;
using UnityEngine;

public class ScoringController : MonoBehaviour
{
    public GameObject player;
    public TextMeshProUGUI scoreUI;

    private int coinScore;
    private int movementScore;
    private int currentScore;

    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;

        scoreUI.color = Color.black;
        SetScoreText();
    }

    public void UpdateScoreOnCoin(int score)
    {
        coinScore += score;

        SetScoreText();
    }

    public void UpdateScoreOnMovement(int score)
    {
        if (score > 0)
        {
            movementScore += (score - movementScore);

            SetScoreText();
        }
    }

    private void SetScoreText()
    {
        scoreUI.text = $"Score: {coinScore + movementScore}";
    }
}
