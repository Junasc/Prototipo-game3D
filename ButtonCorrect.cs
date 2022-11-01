using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCorrect : MonoBehaviour
{
    public Canvas canvas;

    public void closeCanvas()
    {
        canvas.GetComponent<Canvas>().enabled = false;
    }
}
