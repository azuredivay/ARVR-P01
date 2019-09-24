using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class btn : MonoBehaviour, IVirtualButtonEventHandler
{
    public AudioClip MusicClip;
    public AudioSource MusicSource;
    public GameObject mickey;
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //throw new System.NotImplementedException();
        Debug.Log("PRESSED");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("REL");
        
        if (mickey.activeSelf)
        {
            mickey.SetActive(false);
            MusicSource.Stop();
        }
        else if (!mickey.activeSelf)
        {
            mickey.SetActive(true);
            MusicSource.Play();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        mickey.SetActive(true);
        MusicSource.clip = MusicClip;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
