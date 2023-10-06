using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoldScript : MonoBehaviour
{
    public GlobalValues GV;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "Player")
        {
            UnlockLevel();
            StartCoroutine(Coroutine());
            //SceneManager.LoadScene(0);
            //anim.Play("CloseFateIn");
        }
    }

    public void UnlockLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel >= PlayerPrefs.GetInt("levels"))
        {
            PlayerPrefs.SetInt("levels", currentLevel + 1);
        }
    }

    IEnumerator Coroutine()
    {
        anim.Play("CloseFateIn");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(0);
    }
}
