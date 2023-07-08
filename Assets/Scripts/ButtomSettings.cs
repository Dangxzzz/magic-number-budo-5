using UnityEngine;
using UnityEngine.UI;

public class ButtomSettings : MonoBehaviour
{
    #region Variables

    public float Alpha = 0.1f;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        GetComponent<Image>().alphaHitTestMinimumThreshold = Alpha;
    }

    #endregion
}