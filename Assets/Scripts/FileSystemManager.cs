using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileSystemManager : MonoBehaviour
{
    public List<GameObject> content;
    public GameObject postilappu;
    public GameObject mukarandom;
    public Canvas canvas;


    private void Start()
    {
        if (gameObject.name == "FolderManager(Clone)")
        {
            GameObject.Instantiate(mukarandom, canvas.transform);
            GetComponentInChildren<ObjectiveCheck>().todoLappu = postilappu;
        }
    }
}
