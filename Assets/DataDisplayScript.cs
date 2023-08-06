// DataDisplayScript.cs
using UnityEngine;
using UnityEngine.UI;

public class DataDisplayScript : MonoBehaviour
{
    public Text dataDisplayText;

    // Start is called before the first frame update
    void Start()
    {
        // Get the data to display from the DataHolder class
        string data = DataHolder.DataToDisplay;

        // Display the data in the UI
        dataDisplayText.text = data;
    }
}
