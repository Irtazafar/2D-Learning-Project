using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomColor : MonoBehaviour
{
    public Image buttonBackground;
    public void ButtonClicked()
    {
        buttonBackground.color = Random.ColorHSV();
    }
}
