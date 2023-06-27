using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    #region Variables

    public TextMeshProUGUI endGame;
    public int max = 1000;
    public int min = 1;
    public TextMeshProUGUI question;

    public TextMeshProUGUI startText;
    private int _guess;
    private int _iteration;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        startText.text = $"Загадай число от {min} до {max}";
        CalculateNumber();
        question.text = SendMessage();
        _iteration++;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = _guess;
            CalculateNumber();
            question.text = SendMessage();
            _iteration++;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = _guess;
            CalculateNumber();
            question.text = SendMessage();
            _iteration++;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            endGame.text = $"Угадал. Твоё число {_guess} и мне понадобилось {_iteration} попыток!";
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            _iteration = 0;
            endGame.text = "";
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    #endregion

    #region Public methods

    public void CalculateNumber()
    {
        _guess = (min + max) / 2;
    }

    public string SendMessage()
    {
        return $"Твоё число {_guess}?";
    }

    #endregion
}