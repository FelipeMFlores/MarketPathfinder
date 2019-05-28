using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class Map : MonoBehaviour
{

    public GameObject position0;
    public Button start;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartPress()
    {
        position0.SetActive(false);
    }

}
