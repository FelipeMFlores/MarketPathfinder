using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class ListClass
{
  static public List<int> list;
}
public class List : MonoBehaviour
{
    public Text list;
    public Text newProduct;
    public InputField inputfieldname;
    private string[] produtos = new string[] {
        "Vinho", //0
        "Pizza",
        "Água",
        "Frango",
        "Carvão",
        "Carne", //5
        "Ovo",
        "Papel Higiênico",
        "Pão",
        "Leite",
        "Ketchup", //10
        "Shampoo",
    };
    // Start is called before the first frame update
    void Start()
    {
        ListClass.list = new List<int>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddList(){
        bool valido = false;

        for (int i = 0; i < produtos.Length; i++)
        {
            if(produtos[i] == newProduct.text){
                valido = true;
                ListClass.list.Add(i);
                break;
            }
        }

        if(valido){
            list.text = list.text +"\n"+ newProduct.text;
        }
            inputfieldname.Select();
            inputfieldname.text = "";
    
    }

    public void MenuPress(){
        SceneManager.LoadScene(0);
    }
    public void StartPress(){
        SceneManager.LoadScene(1);
    }

    public void RandPress(){
        ListClass.list.Clear();
        list.text = "";
        System.Random rand = new System.Random();
        for (int i = 0; i <produtos.Length; i++)
        {
            ListClass.list.Add(i);
            list.text = list.text +"\n" + produtos[i];
            
        }
    }
}
