using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float speed;
    public GameObject o;
    public float distance;
    void Update()
    {
        gameObject.transform.Rotate( Vector3.up, Time.deltaTime * speed);
        
        o.transform.position = gameObject.transform.position +
            gameObject.transform.forward * distance;
    }
}
