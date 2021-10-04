using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileSystemManager : MonoBehaviour
{
    //public List<GameObject> content;
    public GameObject postilappu;
    public GameObject mukarandom;
    public Canvas canvas;

    private GameObject objekti;


    private void Start()
    {
        StartCoroutine(Vittusaatana());
    }

    IEnumerator Vittusaatana()
    {
        yield return new WaitForSeconds(0.2f);
        if (gameObject.name == "FolderManager(Clone)")
        {
            objekti = GameObject.Instantiate(mukarandom, canvas.transform);
            objekti.GetComponent<RectTransform>().anchoredPosition = new Vector2(Random.Range(-394, 394), Random.Range(-300, 300));
        }
        GetComponentInChildren<ObjectiveCheck>().todoLappu = postilappu;
    }
}
