using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TodoSystem : MonoBehaviour
{
    private GameObject[] folderit;
    public List<GameObject> folders = new List<GameObject>();

    public int rng;

    public GameObject theChosenOne;
    public GameObject mukarandom;

    public GameObject[] postitNotes;
    void Start()
    {
        CreateTask();
    }

    public void CreateTask()
    {
        // Task object spawn system
        folderit = GameObject.FindGameObjectsWithTag("Folder");

        foreach (GameObject a in folderit)
        {
            folders.Add(a.gameObject);
        }

        rng = Random.Range(0, folders.Count);
        theChosenOne = folders[rng];
        GameObject.Instantiate(mukarandom, theChosenOne.transform);

        // Post-it note spawn system        
        int rng2 = Random.Range(0, 2);
        int rng3 = Random.Range(0, gameObject.transform.childCount);
        GameObject.Instantiate(postitNotes[rng2], gameObject.transform.GetChild(rng3));
    }
}
