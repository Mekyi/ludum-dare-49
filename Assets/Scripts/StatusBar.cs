using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusBar : MonoBehaviour
{

    public double Life = 50;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Life -= 0.2 * Time.deltaTime * GameObject.FindGameObjectsWithTag("PostIt").Length;
        Debug.Log(Life);
    }
}
