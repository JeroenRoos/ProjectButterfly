using System.Collections;
using UnityEngine;

public class LevelGeneratie : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine("Transfer");
        }
    }

    IEnumerator Transfer()
    {
        gameObject.transform.parent.position = new Vector3(gameObject.transform.position.x +17.16f, -1,0);

        yield return new WaitForSeconds(1);
    }
