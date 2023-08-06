using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void MainMenuUI()
    {
        SceneManager.LoadScene("MainMenuUI");
    }


    public void ButtonPress()
    {
        Debug.Log("Button Pressed");
    }

}
