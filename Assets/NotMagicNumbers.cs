using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NotMagicNumbers : MonoBehaviour
{
    #region Variables

    public TextMeshProUGUI endGame;
    public TextMeshProUGUI message;

    public int range = 50;

    public TextMeshProUGUI startMessage;
    private int _iterations;
    private int _sum;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        startMessage.text = "Введите число от 1 до 9";
        message.text = SendMessage();
    }

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            message.text = SendMessage();
        }

        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            _sum++;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            _sum += 2;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            _sum += 3;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            _sum += 4;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            _sum += 5;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            _sum += 6;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            _sum += 7;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            _sum += 8;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            _sum += 9;
        }

        if (_sum >= range)
        {
            endGame.text = $"Конец игры, затарчено попыток: {_iterations}";
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _iterations = 0;
            endGame.text = "";
            _sum = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    #endregion

    #region Public methods

    public string SendMessage()
    {
        _iterations++;
        return $"Значене суммы {_sum}";
    }

    #endregion
}