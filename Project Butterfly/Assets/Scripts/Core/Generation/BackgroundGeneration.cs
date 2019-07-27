using System.Collections;
using UnityEngine;

public class BackgroundGeneration : MonoBehaviour
{
    public GameObject backGround;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        backGround.gameObject.transform.position += Vector3.right * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine("BackTransfer");
        }
    }

    IEnumerator BackTransfer()
    {
        gameObject.transform.parent.position = new Vector3(gameObject.transform.position.x + 7.43f, 0, 0);

        yield return new WaitForSeconds(1);
    }
}
