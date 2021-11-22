using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruitManager : MonoBehaviour
{

    public Text levelCleared;

    public GameObject transition;

    public Text totalFruits;

    public Text fruitsCollected;

    private int totalFruistInLevel;

    private void Start()
    {
        totalFruistInLevel = transform.childCount;
    }



    private void Update()
    {
        AllFruitsCollected();
        totalFruits.text = totalFruistInLevel.ToString();
        fruitsCollected.text = transform.childCount.ToString();
    }


    public void AllFruitsCollected()
    {
        if (transform.childCount==0)
        {
            Debug.Log("No quedan Frutas, Victoria");
            levelCleared.gameObject.SetActive(true);
            transition.SetActive(true);
            Invoke("ChangeScene", 1); 
        }
    }


    void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
