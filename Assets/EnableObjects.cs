using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableObjects : MonoBehaviour
{
    public GameObject AllFrame;
    public bool isEnabled = true;

    public Image buttonIcon;
    public Text buttonText;
    public Sprite enableIcon;
    public Sprite disableIcon;
    public Button button;


    public void ButtonClicked()
    {
        isEnabled = !isEnabled;
        AllFrame.SetActive(isEnabled);

        if(isEnabled==true)
        {
            buttonText.text = "Disable";
            buttonIcon.sprite = disableIcon;
            button.GetComponent<Image>().color = Color.red;


        }
        else
        {
            buttonText.text = "Enable";
            buttonIcon.sprite = enableIcon;
            button.GetComponent<Image>().color = Color.blue;
        }
    }
}
