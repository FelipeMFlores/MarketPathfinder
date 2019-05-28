using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // These are all the buttons
    //-------------------------------
    public Button start;
    public Button help;
    public Button exit;
    public Button back;
    //-------------------------------
    // This is the Help Panel
    public GameObject helpPanel;
    //-------------------------------

    // Start is called before the first frame update
    void Start()
    {
        // Disables the panel
        helpPanel.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Function for Start Button, loads Main Scene 
    public void StartPress()
    {
        SceneManager.LoadScene(1);
    }

// Function for Help Button, enables Help Panel
    public void HelpPress()
    {
        helpPanel.SetActive(true);
    }

// Function for Exit Button, exits the application
    public void ExitPress()
    {
        Application.Quit();
    }

// Function for Back Button, disables Help Panel
    public void BackPress()
    {
        helpPanel.SetActive(false);
    }
}

