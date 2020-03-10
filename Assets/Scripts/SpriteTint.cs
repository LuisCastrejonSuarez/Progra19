using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteTint : MonoBehaviour
{
    SpriteRenderer srenderer;

    private void Awake()
    {
        srenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
            StartCoroutine(Damage());
    }
    IEnumerator Damage()
    {
        srenderer.color = Color.white;
        yield return new WaitForSeconds(.3f);
        srenderer.color = Color.red;
        yield return new WaitForSeconds(.3f);
        srenderer.color = Color.white;
        yield return new WaitForSeconds(.3f);
        srenderer.color = Color.red;
        yield return new WaitForSeconds(.3f);
        srenderer.color = Color.white;
        yield return new WaitForSeconds(.3f);
        srenderer.color = Color.red;
        yield return new WaitForSeconds(.3f);
        srenderer.color = Color.white;
    }
}
