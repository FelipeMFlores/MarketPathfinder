using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;


public class Menu : MonoBehaviour
{

    // These are all the buttons
    //-------------------------------
    public Button start;
    public Button list;
    public Button exit;


    // Start is called before the first frame update
    void Start()
    { 
        System.Threading.Thread.Sleep(1000);
        SceneManager.LoadScene(2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Function for Start Button, loads Main Scene 
    public void StartPress()
    {
        if(ListClass.list == null || ListClass.list.Count == 0)
            SceneManager.LoadScene(2);
        else
            SceneManager.LoadScene(1);
    }

    public void ListPress()
    {
        SceneManager.LoadScene(2);
    }


// Function for Exit Button, exits the application
    public void ExitPress()
    {
        Application.Quit();
    }


}

