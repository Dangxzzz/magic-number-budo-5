using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public int min=1;
    public int max=1000;
    private int _guess;
    private int _iteration;
    
    public TextMeshProUGUI startText;
    public TextMeshProUGUI question;
    public TextMeshProUGUI endGame;


    void Start()
    {
        startText.text = $"Загадай число от {min} до {max}";
        CalculateNumber();
        question.text = SendMessage();
        _iteration++;
    }
    
    void Update()
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
            endGame.text=$"Угадал. Твоё число {_guess} и мне понадобилось {_iteration} попыток!";
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            _iteration = 0;
            endGame.text = "";
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void CalculateNumber()
    {
        _guess = (min + max) / 2;
    }

    public string SendMessage()
    {
        return $"Твоё число {_guess}?";
    }

}
