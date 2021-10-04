using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObjectiveCheck : MonoBehaviour
{
    public GameObject goal;
    public GameObject maalitaulu;
    public GameObject todoLappu;

    // Start is called before the first frame update
    void Start()
    {
        string[] nimilista = {"construction", "responsibility", "priority", "region", "championship", "affair",
        "airport", "winner", "singer", "agency", "society", "difficulty",
        "people", "surgery", "reception", "piano", "arrival", "engineering", "injury", "sample", "addition",
        "control", "passenger", "awareness", "way", "failure", "grocery", "guitar", "nature", "thought",
        "difference", "disk", "football", "exam", "promotion", "membership", "throat", "health", "opinion",
        "cousin", "examination", "education", "king", "gate", "scene", "phone", "nation", "oven", "tale", "drawing"};

        int rng = Random.Range(0, nimilista.Length);
        gameObject.name = nimilista[rng];
        gameObject.GetComponentInChildren<TextMeshProUGUI>().text = nimilista[rng];

        goal = Instantiate(maalitaulu);
        int rng2 = Random.Range(0, nimilista.Length);
        goal.name = nimilista[rng2];
        Debug.Log(nimilista[rng2]);
        goal.GetComponentInChildren<TextMeshProUGUI>().text = nimilista[rng2];
        Debug.Log(nimilista[rng2]);

        todoLappu.GetComponentInChildren<TextMeshProUGUI>().text = "Move file " + this.gameObject.name + " to folder " + goal.gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.parent.parent == goal.transform)
        {
            Destroy(todoLappu);
        }
    }
}

