using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootBib : MonoBehaviour
{
    public Rigidbody2D bibBody;
    public byte flyStrength;

    public delegate void OnPassedPipeEnter(int Score);
    public event OnPassedPipeEnter OnPassedPipe;
    private int Score = 0;

    // Start is called before the first frame update
    void Start()
    {
        OnPassedPipe?.Invoke(Score);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) == true) {
           bibBody.velocity = Vector2.up * flyStrength;
        }

        if (Input.GetKeyDown(KeyCode.Escape)  == true)
        {
            Application.Quit();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score++;
        OnPassedPipe?.Invoke(Score);
    }

}
