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
        ListClass.list.Add(Convert.ToInt32(newProduct.text));
        list.text = list.text +"\n"+ newProduct.text;
        
        inputfieldname.Select();
        inputfieldname.text = "";
    }

    public void MenuPress(){
        SceneManager.LoadScene(0);
    }
    public void StartPress(){
        SceneManager.LoadScene(1);
    }
}
