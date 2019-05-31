using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
using System;

public class Map : MonoBehaviour
{
    const int NLOCATIONS = 24;
    public GameObject[] locations = new GameObject[NLOCATIONS];
    bool[] locationsStatus = new bool[NLOCATIONS];
    List<int> shopList = new List<int>();
    public Button check;
    public Text nextItem;
    public Text productsInLoc;
  

    // Start is called before the first frame update
    void Start()
    {
        shopList = ListClass.list;
        BuildLocationStatus();
        TurnLocations();
        ChangeCheckText();
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

    void ChangeCheckText(){
        if(shopList.Count != 0){
            int item = shopList[0]; 
            nextItem.text = "Product" + item;
        }
        else
            nextItem.text = "DONE";

    }

    public void CheckPress(){
        if(shopList.Count != 0){
            int item = shopList[0];
            if (item != -1)
            {
                locationsStatus[item] = false;
                locations[item].SetActive(false);
                shopList.RemoveAt(0);
            }
        }
            ChangeCheckText();
        
    }
    
    public void RedoPress(){
        System.Random rand = new System.Random();
        for (int i = 0; i <NLOCATIONS; i++)
        {
            locationsStatus[i] = rand.Next(2) == 0;
        }

        
        BuildShopList();        
        TurnLocations();
        ChangeCheckText();
    }

    void BuildLocationStatus(){
        foreach (int i in shopList)
        {
            locationsStatus[i] = true;
        }
    }

    void BuildShopList(){
        shopList.Clear();
        for (int i = 0 ; i < NLOCATIONS; i++)
        {
            if (locationsStatus[i])
            {
                shopList.Add(i);
            }
        }
    }

    public void LocationsButtonsPress(GameObject location){
        productsInLoc.text = location.name;
    }

    public void BackPress(){
        SceneManager.LoadScene(0);
    }

}
