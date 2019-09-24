using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class toggleBack : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject Reviews;
    public GameObject BookInfo;
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //throw new System.NotImplementedException();

        Debug.Log("BACK PRESSED");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        if (Reviews.activeSelf)
        {
            BookInfo.SetActive(true);
            Reviews.SetActive(false);
        }
        else if (BookInfo.activeSelf)
        {
            BookInfo.SetActive(false);
            Reviews.SetActive(true);
        }
        Debug.Log("BACK REL");

    }
    // Start is called before the first frame update
    void Start()
    {
        BookInfo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
