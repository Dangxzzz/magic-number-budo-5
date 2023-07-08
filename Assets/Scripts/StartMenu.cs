using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    #region Variables

    public Button ExitButtom;
    public Button MagicNumberButtom;
    public Button SumNumberButtom;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        MagicNumberButtom.onClick.AddListener(OnMagicNumberBottomClick);
        SumNumberButtom.onClick.AddListener(OnSumNumberButtomClick);
        ExitButtom.onClick.AddListener(OnExitButtomClick);
    }

    #endregion

    #region Public methods

    public void OnExitButtomClick()
    {
        Debug.Log("ExitGame");
        Application.Quit();
    }

    public void OnMagicNumberBottomClick()
    {
        SceneManager.LoadScene(Scenes.MagicNumber);
    }

    public void OnSumNumberButtomClick()
    {
        SceneManager.LoadScene(Scenes.SumNumber);
    }

    #endregion
}