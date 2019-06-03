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
            if(rand.Next(2) == 0){
                if(produtos[i] == "NAO")
                    continue;
                
                ListClass.list.Add(i);
                list.text = list.text +"\n" + produtos[i];
            }
        }
    }
}
