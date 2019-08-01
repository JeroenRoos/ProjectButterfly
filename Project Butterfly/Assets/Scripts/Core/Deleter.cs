using UnityEngine;

public class Deleter : MonoBehaviour
{
    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x < player.transform.position.x - 8)
        {
            Destroy(gameObject);
        }
    }

   
}
