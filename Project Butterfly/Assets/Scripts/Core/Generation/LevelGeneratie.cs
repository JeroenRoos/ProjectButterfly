using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneratie : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D collision)
    
    {
        //Debug.Log("ik hit de collider");
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine("Transfer");
        }
    }
    IEnumerator Transfer()
    {
        //Debug.Log("ben ik hier");

        
        gameObject.transform.parent.position = new Vector3(gameObject.transform.position.x +17.16f, -1,0);
        yield return new WaitForSeconds(1);

    }


}
