using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NotMagicNumbers : MonoBehaviour
{
    #region Variables

    public TextMeshProUGUI Message;

    public int Range = 50;
    private readonly KeyCode[] _inputKeys =
    {
        KeyCode.Alpha1, KeyCode.Alpha2, KeyCode.Alpha3,
        KeyCode.Alpha4, KeyCode.Alpha5, KeyCode.Alpha6,
        KeyCode.Alpha7, KeyCode.Alpha8, KeyCode.Alpha9,
    };

    private int _sum;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        Message.text = SendMessage();
    }

    private void Update()
    {
        for (int i = 0; i < _inputKeys.Length; i++)
        {
            if (Input.GetKeyDown(_inputKeys[i]))
            {
                _sum += i + 1;
                Message.text = SendMessage();
            }
        }

        if (_sum >= Range)
        {
            Iterations.IsMagicNumber = false;
            SceneManager.LoadScene(Scenes.End);
        }
    }

    #endregion

    #region Public methods

    public string SendMessage()
    {
        Iterations.IterationCount++;
        return $"Sum:{_sum}";
    }

    #endregion
}