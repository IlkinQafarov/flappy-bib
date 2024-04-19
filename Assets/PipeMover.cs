using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PipeMover : MonoBehaviour
{
    public byte moveSpeed = 5;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject bib = GameObject.Find("bib");

        if (transform.position.x < -15)
        {

            GameObject.Destroy(gameObject);
        }

        if (bib.GetComponent<RootBib>().IsAlive())
        {
            transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        }
        
    }
}
