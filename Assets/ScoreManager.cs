using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    [SerializeField]private RootBib rootBib;

    void Start()
    {
        
        rootBib.OnPassedPipe += ScoreUp;
    }

    void ScoreUp(int score)
    {
        ScoreText.text = $"Score: {score.ToString()}";
    }
}
