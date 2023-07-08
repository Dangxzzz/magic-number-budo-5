using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MagicNumbers : MonoBehaviour
{
    #region Variables

    public Button BiggerButton;
    public TextMeshProUGUI IterationsLabel;

    public int max = 1000;
    public int min = 1;
    public TextMeshProUGUI Question;
    public Button RightButton;
    public Button SmallerButton;
    public TextMeshProUGUI StartText;
    private int _guess;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        StartText.text = $"Choose the number between {min} and {max}";
        MakeGameCircle();
        BiggerButton.onClick.AddListener(OnBiggerButtomClick);
        SmallerButton.onClick.AddListener(OnSmallerButtonClick);
        RightButton.onClick.AddListener(OnRightButtonClick);
    }

    private void Update()
    {
        IterationsLabel.text = $"Iterations: {Iterations.IterationCount}";
    }

    #endregion

    #region Public methods

    public void CalculateNumber()
    {
        _guess = (min + max) / 2;
    }

    public string SendMessage()
    {
        return $"Your number {_guess}?";
    }

    #endregion

    #region Private methods

    private void MakeGameCircle()
    {
        CalculateNumber();
        Question.text = SendMessage();
        Iterations.IterationCount++;
    }

    private void OnBiggerButtomClick()
    {
        min = _guess;
        MakeGameCircle();
    }

    private void OnRightButtonClick()
    {
        Iterations.IsMagicNumber = true;
        SceneManager.LoadScene(Scenes.End);
    }

    private void OnSmallerButtonClick()
    {
        max = _guess;
        MakeGameCircle();
    }

    #endregion
    
}