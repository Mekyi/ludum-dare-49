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

        int rng4 = Random.Range(0,2);

        foreach (var folder in GameObject.FindGameObjectsWithTag("Folder"))
        {
            folders.Add(folder);
        }

        /*if (GameObject.FindGameObjectsWithTag("Folder").Length > 0 && rng4 == 0)
        {
            Debug.Log(GameObject.FindGameObjectsWithTag("Folder").Length);
            rng = Random.Range(0, folders.Count);
            theChosenOne = folders[rng];
            GameObject.Instantiate(mukarandom, theChosenOne.transform);
            Debug.Log("if", this);

            // Post-it note spawn system
            int rng2 = Random.Range(0, 2);
            int rng3 = postittinrg();
            GameObject postinote = GameObject.Instantiate(postitNotes[rng2], gameObject.transform.GetChild(rng3));
            //spagetti.GetComponent<FileSystemManager>().content.Add(mukarandom);
            theChosenOne.GetComponent<FileSystemManager>().postilappu = postinote; // t�st� valitat
        }
        else
        {*/
            spagetti = GameObject.Instantiate(folderObject);
            Debug.Log("else", this);

            // Post-it note spawn system
            int rng2 = Random.Range(0, 2);
            int rng3 = postittinrg();
            GameObject postinote = GameObject.Instantiate(postitNotes[rng2], gameObject.transform.GetChild(rng3));
            //spagetti.GetComponent<FileSystemManager>().content.Add(mukarandom);
            spagetti.GetComponent<FileSystemManager>().postilappu = postinote; // t�st� valitat

        //}


    }

        IEnumerator CreateTaskObject()
        {
            while (true)
            {
                Debug.Log("CreateTask");
                CreateTask();
                yield return new WaitForSeconds(Random.Range(2, 5));
            }
        }

        private int postittinrg()
        {
            int rng3 = Random.Range(0, gameObject.transform.childCount);
            while (gameObject.transform.GetChild(rng3).childCount != 0)
            {
            //rng3 = Random.Range(0, gameObject.transform.childCount);

            Debug.Log(rng3);
            }
            return rng3;
        }
}
