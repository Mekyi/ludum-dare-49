using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusBar : MonoBehaviour
{

    public double Life = 50;
    private double decay = 0.25;
    public double difficulty = 0.3;
    public GameObject levelManager;
    public Slider slider;



    // Update is called once per frame
    void Update()
    {
        if (Life >= 0 && Life <= 100)
        {
            Life -= decay * Time.deltaTime * (difficulty*GameObject.FindGameObjectsWithTag("PostIt").Length+1);
            //Debug.Log(Life);
        }
        else
        {
            levelManager.GetComponent<LevelManager>().EndGame();
        }

        slider.value = (float)Life;
    }

    public void addTime()
    {
        Life += 2;
        Debug.Log("Added 2 life");
    }

    public void addTime(int i)
    {
        Life += i;
    }



}
