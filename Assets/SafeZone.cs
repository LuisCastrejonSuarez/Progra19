using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeZone : MonoBehaviour
{
    float count = 0.3f;
    private void OnTriggerStay(Collider other)
    {
        if(count<0)
        {
            PlayerController pc = other.gameObject.GetComponent<PlayerController>();
            if (pc != null)
            {
                pc.recover();
            }
        }
        else
        {
            count -= Time.deltaTime;
        }
    }
}
