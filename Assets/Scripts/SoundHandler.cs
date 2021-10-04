using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundHandler : MonoBehaviour
{

    public AudioSource audio;
    public AudioClip[] audioList;
    public AudioClip[] musicList;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (!audio.isPlaying)
        {
            audio.clip = musicList[Random.Range(0, musicList.Length)];
            audio.Play();
        }

        if (Input.GetMouseButtonDown(0))
        {
            audio.PlayOneShot(audioList[0]);
        }

        if (Input.GetMouseButtonUp(0))
        {
            audio.PlayOneShot(audioList[1]);
        }
    }

    public void FolderOpen()
    {
        audio.PlayOneShot(audioList[2]);
    }

}
