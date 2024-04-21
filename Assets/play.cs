using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Play : MonoBehaviour
{
    [ContextMenu("Res SIze")] public void ResSize()
    {
        Debug.Log(Screen.currentResolution);
    }
    [SerializeField] private GameObject canvaMain;
    [SerializeField] private GameObject canvaCredits;
    [SerializeField] private TextMeshProUGUI creditText;
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void LeaveGame()
    {
        Application.Quit();
    }
    private bool isCanvaCreditsActive = false;
    public void Credits()
    {
        if (isCanvaCreditsActive)
        {
            creditText.text = "credits";
            canvaCredits.SetActive(false);
            canvaMain.SetActive(true);
            isCanvaCreditsActive = !isCanvaCreditsActive;
        }
        else
        {
            creditText.text = "< back";
            canvaMain.SetActive(false);
            canvaCredits.SetActive(true);
            isCanvaCreditsActive = !isCanvaCreditsActive;
        }
    }
}
