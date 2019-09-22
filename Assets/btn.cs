using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class btn : MonoBehaviour, IVirtualButtonEventHandler
{
    public AudioClip MusicClip;
    public AudioSource MusicSource;
    VirtualButtonBehaviour[] virtualButtonBehaviours;
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //throw new System.NotImplementedException();
        Debug.Log("PRESSED");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("REL");
        MusicSource.Play();

    }

    // Start is called before the first frame update
    void Start()
    {
        virtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();
 
        for (int i = 0; i < virtualButtonBehaviours.Length; i++) virtualButtonBehaviours[i].RegisterEventHandler(this);
        MusicSource.clip = MusicClip;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
