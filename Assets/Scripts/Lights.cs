using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{
    public Light light;
    public float length;
    void Update()
    {
        Terror();
    }
    void Color()
    {
        light.color = new Color((Mathf.Sin(Time.time * length) + 1)
            * 0.5f, 0.5f, 0.5f);
    }
    void Sin()
    {
        light.intensity = Mathf.Sin(Time.time * length) * 0.5f + 1;
    }
    void Terror()
    {
        if (Random.Range(0f, 1f) < 0.2f)
            light.intensity = 0.1f;
        else
            light.intensity = 1f;
    }
}
