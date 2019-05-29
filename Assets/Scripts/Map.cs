using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
using System;

public class Map : MonoBehaviour
{

    public GameObject[] locations = new GameObject[25];
    bool[] locationsStatus = new bool[25];
    public Button check;


    // Start is called before the first frame update
    void Start()
    {
 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TurnLocations(){
        for (int i = 0; i < locationsStatus.Length; i++)
        {
            locations[i].SetActive(locationsStatus[i]);
        }

    }

    int FindNextItem(){
        for (int i = 0 ; i < locationsStatus.Length; i++)
        {
            if (locationsStatus[i])
            {
                return i;
            }
        }
        return -1;
    }
    void ChangeCheckText(){
        int item = FindNextItem(); 
        check.GetComponentInChildren<Text>().text = "Product" + item;

    }

    public void CheckPress(){
        int item = FindNextItem();
        if (item != -1)
        {
            locationsStatus[item] = false;
            locations[item].SetActive(false);
        }
        ChangeCheckText();
    }
    
    public void RedoPress(){
        System.Random rand = new System.Random();
        for (int i = 0; i < locationsStatus.Length; i++)
        {
            locationsStatus[i] = rand.Next(2) == 0;
        }
        
        TurnLocations();
        ChangeCheckText();
    }


}
