using TMPro;
using UnityEngine;
using UnityEngine.UI;

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

        SetScoreText();
    }

    public void UpdateScoreOnCoin(int score)
    {
        Debug.Log($"Updating score on coin grab: {score}");
        coinScore += score;

        SetScoreText();
    }

    public void UpdateScoreOnMovement(int score)
    {
        if (score > 0)
        {
            Debug.Log($"Updating score on movement: {score}");
            movementScore += (score - movementScore);

            SetScoreText();
        }
    }

    private void SetScoreText()
    {
        Debug.Log($"Updating current score: {currentScore}");
        scoreUI.text = $"Score: {coinScore + movementScore}";
    }
}
