using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{

    public Text dataDisplayText;
    // Start is called before the first frame update
    void Start()
    {
        // Get the data to display from the DataHolder class
        string data = DataHolder.DataToDisplay;

        // Display the data in the UI
        dataDisplayText.text = "SCORE: " + data;
    }
    public void MainMenuUI()
    {
        SceneManager.LoadScene("MainMenuUI");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
