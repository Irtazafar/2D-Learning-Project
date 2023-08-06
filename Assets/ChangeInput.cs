using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

//THIS SCRIPT IS USED TO CHANGE THE BEHAVIOUR USING TABS
//and also we can submit using the use of mouse. 
public class ChangeInput : MonoBehaviour
{
    EventSystem system;
    public Selectable firstInput;
    public Button submitButton;

    void Start()
    {
        system = EventSystem.current;
        //used to intialize the selected. 
        firstInput.Select();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            Selectable next = system.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
            if(next!=null)
            {
                next.Select();
            }
        }else if(Input.GetKeyDown(KeyCode.Return))
        {
            submitButton.onClick.Invoke();
            Debug.Log("Button Pressed");
        }
    }
}
