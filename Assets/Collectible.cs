using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerController pc=other.gameObject.GetComponent<PlayerController>();
        if(pc!=null)
        {
            pc.Collect();
            gameObject.SetActive(false);
        }
    }
}
