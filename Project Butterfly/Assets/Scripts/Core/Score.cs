using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GameObject plyer;
    public TextMeshProUGUI scoreUI;
    public int xscore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float positie = plyer.transform.position.x;
        xscore = Mathf.RoundToInt(positie);
        scoreUI.text = xscore.ToString();
    }
}
