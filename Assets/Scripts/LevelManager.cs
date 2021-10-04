using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    [Tooltip("The amount of post-it notes at the same time on the screen")]
    int loseCondition = 10;

    [SerializeField]
    GameObject computerScreen;

    [SerializeField]
    GameObject loseCanvasObject;

    [SerializeField]
    Material loseScreenMaterial;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("PostIt").Length >= loseCondition)
        {
            EndGame();
        }
    }

    public void EndGame()
    {
        loseCanvasObject.SetActive(true);
        Time.timeScale = 0f;
        computerScreen.GetComponent<MeshRenderer>().material = loseScreenMaterial;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
