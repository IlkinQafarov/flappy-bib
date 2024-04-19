using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuBib : MonoBehaviour
{
    private float timer = 0.3f;
    private bool flipBib = false;
    private void Update()
    {
        if (timer >= 0.5)
        {
            FlipBib();
            timer = 0;
        }
        else
        {
            timer += Time.deltaTime;
        }
        
    }

    private void FlipBib()
    {
        gameObject.GetComponent<SpriteRenderer>().flipX = flipBib;
        flipBib = !flipBib;
    }
}
