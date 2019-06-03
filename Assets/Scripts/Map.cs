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
    public GameObject nodeMenu;
    public Text nodeMenuText;
    bool[] locationsStatus = new bool[NLOCATIONS];
    List<int> shopList = new List<int>();
    public Button check;
    public Text nextItem;
    public Text productsInLoc;
    public GameObject HelpPanel;
    public GameObject hereMenu;
    public string[] produtos = new string[] {
        "Laranja", //0
        "Alface",
        "Chocolate",
        "Leite",
        "Manteiga",
        "Carne", //5
        "Maionese",
        "Salgadinho",
        "Água",
        "Fralda",
        "Sabonete", //10
        "NAO",
        "NAO",
        "Vassoura",
        "Detergente",
        "Pilha", //15
        "Cereal",
        "Achocolatado",
        "Pão",
        "Vinho",
        "Vodka", //20
        "Cerveja",
        "Refrigerante",
        "NAO"
    };
  
    // Start is called before the first frame update
    void Start()
    {
        hereMenu.SetActive(false);
        nodeMenu.SetActive(false);
        HelpPanel.SetActive(false);
        if (ListClass.list != null)
            shopList = ListClass.list;
        BuildMap(24);
    }

    // Update is called once per frame
    void Update()
    {
        NextItemColor();
    }
 



    //-------- BUTTONS PRESS --------------
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
        if (shopList.Count != 0)
        {
            shopList = Graphs.BestRoute(shopList,24);
        }
        ChangeCheckText();
        NextItemColor();
        SetNumbers();
    }
    public void LocationsButtonsPress(GameObject location){
        string item = Convert.ToString(location.name[10]);
        if(node.name[11] != ')' )
        item += Convert.ToString(location.name[11]);
        productsInLoc.text = produtos[Convert.ToInt32(item)];
        NextItemColor();
    }

    public void BackPress(){
        SceneManager.LoadScene(2);
    }
    public void HelpPress(){
        HelpPanel.SetActive(true);
    }
    public void HelpBack(){
        HelpPanel.SetActive(false);
    }


    // --------- BUILD FUNCTIONS  ------------------
    void BuildMap(int pos){
        BuildLocationStatus();
        TurnLocations();
        if (shopList.Count != 0)
        {
            shopList = Graphs.BestRoute(shopList,pos);
        }
        ChangeCheckText();
        NextItemColor();
        SetNumbers();
    }
    void BuildLocationStatus(){
        for (int i = 0; i < NLOCATIONS; i++)
            locationsStatus[i] = false;  
        foreach (int i in shopList)
            locationsStatus[i] = true;
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

    void TurnLocations(){
        for (int i = 0; i < NLOCATIONS; i++)
        {
            locations[i].SetActive(locationsStatus[i]);
        }

    }

    void ChangeCheckText(){
        if(shopList.Count != 0){
            int item = shopList[0]; 
            nextItem.text = produtos[item];
        }
        else
            nextItem.text = "DONE";

    }

    // ------------- ROUTE FUNCTIONS -----------------------------
    void NextItemColor(){
        if(shopList.Count != 0){
            int item = shopList[0]; 
            
            locations[item].GetComponent<Button>().Select();
            locations[item].GetComponent<Button>().OnSelect(null);
        }
        
    }

    void SetNumbers(){

        int i = 1;
        foreach (int item in shopList)
        {
            locations[item].GetComponentInChildren<Text>().text = Convert.ToString(i++);
        }
    }



    //----------- NODE MENU FUNCTIONS --------------------------
    GameObject node;
    public void ShowNodeMenu(GameObject location){
        node = location;
        nodeMenu.SetActive(true);
        string item = Convert.ToString(location.name[10]);
        if(node.name[11] != ')' )
        item += Convert.ToString(location.name[11]);
        nodeMenuText.text = "- " + produtos[Convert.ToInt32(item)];
    }
    
    public void CloseNodeMenu(){
        nodeMenu.SetActive(false);
        hereMenu.SetActive(false);
    }

    public void CheckNodeMenu(){
        //remover nodo lista
        string item = Convert.ToString(node.name[10]);
        if(node.name[11] != ')' )
            item += Convert.ToString(node.name[11]);

        Debug.Log(item);
        shopList.Remove(Convert.ToInt32(item));
        //perguntar se esta aqui

        //BuildMap();
        BuildLocationStatus();
        TurnLocations();
        ChangeCheckText();
        NextItemColor();
        SetNumbers();
        CloseNodeMenu();
        //closenode menu
        
        hereMenu.SetActive(true);
    }

    public void EstouAqui(){
        string item = Convert.ToString(node.name[10]);
        if(node.name[11] != ')' )
            item += Convert.ToString(node.name[11]);
        BuildMap(Convert.ToInt32(item));
        hereMenu.SetActive(false);
    }

    public void HereYes(){
        EstouAqui();
        CheckPress();
    }


}
