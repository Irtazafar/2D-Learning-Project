using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string m_Text;
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game closed");
    }

    public void ButtonUI()
    {
        SceneManager.LoadScene("ButtonUI");
    }

    public void GameOverUI()
    {
        SceneManager.LoadScene("GameoverUI");
    }

    public void scrollUI()
    {
        SceneManager.LoadScene("VerticalScrollExample2");
    }

    public void GridUI()
    {
        SceneManager.LoadScene("GridLayout");
    }

    public void LoginUI()
    {
        SceneManager.LoadScene("LoginPage");
    }
    public void StartButton()
    {
        //Direct Scene Loading 
        //SceneManager.LoadScene("FirstUI");

        //Async Scene Loading 
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        yield return null;

        //Begin to load the Scene you specify
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync("FirstUI");

        //Don't let the Scene activate until you allow it to
        asyncOperation.allowSceneActivation = false;
        Debug.Log("Pro :" + asyncOperation.progress);
        //When the load is still in progress, output the Text and progress bar
        while (!asyncOperation.isDone)
        {
            //Output the current progress
            m_Text = "Loading progress: " + (asyncOperation.progress * 100) + "%";

            Debug.Log(m_Text);

            // Check if the load has finished
            if (asyncOperation.progress >= 0.9f)
            {
                //Change the Text to show the Scene is ready
                m_Text = "Press the space bar to continue";

                Debug.Log(m_Text);

                //Wait to you press the space key to activate the Scene
                //if (Input.GetKeyDown(KeyCode.Space))
                    //Activate the Scene
                    asyncOperation.allowSceneActivation = true;
            }

            yield return null;
        }


    }
}


