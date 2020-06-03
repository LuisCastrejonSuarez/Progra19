using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public string name, dialogue;
    private void OnTriggerEnter(Collider other)
    {
        PlayerController pc = other.gameObject.GetComponent<PlayerController>();
        if (pc != null)
        {
            pc.ShowDialogue(name, dialogue);
        }
    }
}
