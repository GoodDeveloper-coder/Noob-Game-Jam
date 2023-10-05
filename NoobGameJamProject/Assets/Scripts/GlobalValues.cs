using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalValues : MonoBehaviour
{
    public bool PlayerFoundGold;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (PlayerFoundGold)
       {
            SceneManager.LoadScene(0);
       } 
    }
}
