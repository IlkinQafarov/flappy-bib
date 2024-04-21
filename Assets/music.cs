using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Music : MonoBehaviour
{
    private GameObject musicObject;
    public void ChangeVolume(float volume)
    {
      musicObject.GetComponent<AudioSource>().volume = volume;
    }
    private void Start()
    {
        musicObject = GameObject.FindGameObjectWithTag("GameMusic");
    }
    
}
