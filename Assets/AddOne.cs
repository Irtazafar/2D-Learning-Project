using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddOne : MonoBehaviour
{
    public Text numberText;
    public int num = 0;

    public void ButtonClicked()
    {
        num++;
        numberText.text = num.ToString();
    }
}
