using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TodoSystem : MonoBehaviour
{
    public List<GameObject> folders = new List<GameObject>();

    public int rng;

    [SerializeField]
    GameObject theChosenOne;
    public GameObject mukarandom;
    public GameObject folderObject;

    public GameObject[] postitNotes;

    [SerializeField]
    GameObject spagetti;

    private void Start()
    {
        StartCoroutine(CreateTaskObject());
    }

    public void CreateTask()
    {
        // Task object spawn system

        int rng4 = Random.Range(0, 1);

        foreach (var folder in GameObject.FindGameObjectsWithTag("Folder"))
        {
            folders.Add(folder);
        }

        if (GameObject.FindGameObjectsWithTag("Folder").Length > 0 && rng4 == 0)
        {
            Debug.Log(GameObject.FindGameObjectsWithTag("Folder").Length);
            rng = Random.Range(0, folders.Count);
            theChosenOne = folders[rng];
            GameObject.Instantiate(mukarandom, theChosenOne.transform);
            spagetti = theChosenOne;
            Debug.Log("if", this);
        }
        else
        {
            spagetti = GameObject.Instantiate(folderObject);

            Debug.Log("else", this);

        }


        // Post-it note spawn system
        int rng2 = Random.Range(0, 2);
        int rng3 = Random.Range(0, gameObject.transform.childCount);
        GameObject postilappu = GameObject.Instantiate(postitNotes[rng2], gameObject.transform.GetChild(rng3));
        spagetti.GetComponent<FileSystemManager>().content.Add(mukarandom);
        spagetti.GetComponent<FileSystemManager>().postilappu = postilappu;
    }

    IEnumerator CreateTaskObject()
    {
        Debug.Log("CreateTask", this);
        CreateTask();
        yield return new WaitForSeconds(10);
    }
}
