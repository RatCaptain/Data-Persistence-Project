using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    private int highScore;
    private string highScoreName;
    void Start()
    {
        highScore = MenuManager.Instance.highScore;
        highScoreName = MenuManager.Instance.highScoreName;

        highScoreText.text = "The high score is: " + highScoreName + " : " + highScore;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        MenuManager.Instance.Save();

        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
}
