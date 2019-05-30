using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
using System;

public class Map : MonoBehaviour
{
    const int NLOCATIONS = 25;
    public GameObject[] locations = new GameObject[NLOCATIONS];
    public Button[] locationsButtons = new Button[NLOCATIONS];
    bool[] locationsStatus = new bool[NLOCATIONS];
    public Button check;
    public Text productsInLoc;


    // Start is called before the first frame update
    void Start()
    {
 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TurnLocations(){
        for (int i = 0; i < NLOCATIONS; i++)
        {
            locations[i].SetActive(locationsStatus[i]);
        }

    }

    int FindNextItem(){
        for (int i = 0 ; i < NLOCATIONS; i++)
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
        for (int i = 0; i <NLOCATIONS; i++)
        {
            locationsStatus[i] = rand.Next(2) == 0;
        }
        
        TurnLocations();
        ChangeCheckText();
    }

    public void LocationsButtonsPress(GameObject location){
        productsInLoc.text = location.name;
    }


}
