// DataTransferScript.cs
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DataTransferScript : MonoBehaviour
{
    // Data to be sent to the GameoverUI scene
    public string dataToSend;

    //Input field data 
    public InputField inputField;

    // Function to load the GameoverUI scene and transfer data
    public void LoadGameoverScene()
    {
        //CONSTANT
        // Store the data to be sent in a static variable to access from the next scene
        //DataHolder.DataToDisplay = "100";

        //Input Field Data
        DataHolder.DataToDisplay = inputField.text;

        // Load the GameoverUI scene
        SceneManager.LoadScene("GameoverUI");
    }
}
