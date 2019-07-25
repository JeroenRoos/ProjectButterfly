using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public GameObject plyer;
    public TextMeshProUGUI scoreUI;
    public int score;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float positie = plyer.transform.position.x;
        score = Mathf.RoundToInt(positie);
        scoreUI.text = score.ToString();
    }
}
