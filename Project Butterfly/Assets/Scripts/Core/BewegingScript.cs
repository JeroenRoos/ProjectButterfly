using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BewegingScript : MonoBehaviour
{
    public float upForce = 0f;
    public float sideForce = -1f;
    public void Start()
    {
        float xForce = sideForce;
        float yForce = upForce;

        Vector2 force = new Vector2(xForce, yForce);

        GetComponent<Rigidbody2D>().velocity = force;
    }
}
 