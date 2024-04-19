using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField]private GameObject pipe;
    private float timer = 2.5f;
    public RootBib bib;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 3)
        {
            SpawnPipe();
            timer = 0;
        }
        else {
            timer += Time.deltaTime;
        }
    }

    void SpawnPipe() {
        if (pipe != null && bib.IsAlive()) {
            float low = -3.5f;
            float high = 3.5f;

            Instantiate(pipe, new Vector3(transform.position.x, UnityEngine.Random.Range(low, high), 0), transform.rotation);
        }
        
    }
}
