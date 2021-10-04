using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveCheck : MonoBehaviour
{
    public GameObject goal;
    public GameObject maalitaulu;
    public GameObject todoLappu;

    // Start is called before the first frame update
    void Start()
    {
        goal = Instantiate(maalitaulu);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.parent == goal.transform)
        {
            Destroy(todoLappu);
        }
    }
}
