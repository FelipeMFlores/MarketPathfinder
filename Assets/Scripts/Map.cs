using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
using System;

public class Map : MonoBehaviour
{

    public GameObject[] locations = new GameObject[25];
    public Button redo;


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TurnLocations(bool[] locationsStatus){
        for (int i = 0; i < locationsStatus.Length; i++)
        {
            locations[i].SetActive(locationsStatus[i]);
        }

    }
    
    public void RedoPress(){
        System.Random rand = new System.Random();
        bool[] locationsStatus = new bool[25];
        for (int i = 0; i < locationsStatus.Length; i++)
        {
            locationsStatus[i] = rand.Next(2) == 0;
        }
        
        TurnLocations(locationsStatus);
    }


}
