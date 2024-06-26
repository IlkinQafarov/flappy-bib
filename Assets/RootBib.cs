using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RootBib : MonoBehaviour
{
    public Rigidbody2D bibBody;
    public float flyStrength;
    private bool isBibAlive = true;
    [SerializeField] private GameObject gameover;
    [SerializeField] private Sprite bibDead;

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
        if (Input.GetKeyDown(KeyCode.Mouse0) && isBibAlive) {
           bibBody.velocity = Vector2.up * flyStrength;
        }

        if (Input.GetKeyDown(KeyCode.Escape)  == true)
        {
            GoMainMenu();
        }

        if (transform.position.y > 5 || transform.position.y < -5)
        {
            GameOver();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "scoreup" && isBibAlive)
        {
            ScoreUp();
        }

    }

    public void GoMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "toppipe" || collision.gameObject.name == "bottompipe")
        {
            GameOver();
        }
    }


    private void ScoreUp()
    {
        Score++;
        OnPassedPipe?.Invoke(Score);
    }
    private void GameOver()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = bibDead;
        gameover.SetActive(true);
        NotAlive();
    }

    private void NotAlive()
    {
        isBibAlive = false;
    }
    public bool IsAlive() { return isBibAlive; }
    [ContextMenu("restart")]public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("works");
    }
}
