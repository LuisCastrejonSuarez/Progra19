using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DIalogueController : MonoBehaviour
{
    public Text txtName;
    public Text txtDialogue;
    void Start()
    {
        txtName.text = "";
        txtDialogue.text = "";
    }
    public void ShowText(string name, string dialogue)
    {
        gameObject.SetActive(true);
        StartCoroutine(_ShowText(name, dialogue));

    }
    private IEnumerator _ShowText(string name, string dialogue)
    {
        txtName.text = name;
        txtDialogue.text = "";
        for (int i=0;i<dialogue.Length;++i)
        {
            txtDialogue.text += dialogue[i];
            yield return new WaitForSeconds(0.1f);
        }
        yield return null;
    }
}
