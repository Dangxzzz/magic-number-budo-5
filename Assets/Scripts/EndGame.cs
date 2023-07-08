using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    #region Variables

    public Button ReplayButton;
    public Button StartMenuButton;
    public TextMeshProUGUI WinLabel;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        WinLabel.text = $"Game over!\nYou use {Iterations.IterationCount} iterations";
        Iterations.IterationCount = 0;
        ReplayButton.onClick.AddListener(OnReplayButtonClick);
        StartMenuButton.onClick.AddListener(OnStartMenuButtonClick);
    }

    #endregion

    #region Public methods

    public void OnReplayButtonClick()
    {
        if (Iterations.IsMagicNumber)
        {
            SceneManager.LoadScene(Scenes.MagicNumber);
        }
        else
        {
            SceneManager.LoadScene(Scenes.SumNumber);
        }
    }

    public void OnStartMenuButtonClick()
    {
        SceneManager.LoadScene(Scenes.Start);
    }

    #endregion
}