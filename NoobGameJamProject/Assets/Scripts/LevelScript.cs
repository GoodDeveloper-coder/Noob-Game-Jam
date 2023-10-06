using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelScript : MonoBehaviour
{
    int levelInLock;
    public Button[] buttonns;

    public GameObject[] LocationDisplay;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteAll();

        //levelInLock = PlayerPrefs.SetInt("levels", 1);


        levelInLock = PlayerPrefs.GetInt("levels", 1);

        for (int i = 0; i < LocationDisplay.Length; i++)
        {
            LocationDisplay[i].SetActive(false);
        }

        for (int i = 0; i < levelInLock; i++)
        {
            LocationDisplay[i].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*
         
        if (PlayerPrefs.GetInt("levels") >= 2)
        {
            //PlayerPrefs.DeleteAll();
            //PlayerPrefs.DeleteKey("levels");
            PlayerPrefs.SetInt("levels", 1);
        }
        */
    }

    public void handLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex); 
    }

    public void ClearPlayerPrefs()
    {
        PlayerPrefs.SetInt("levels", 0);
    }
}
