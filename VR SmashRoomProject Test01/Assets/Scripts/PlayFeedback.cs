using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayFeedback : MonoBehaviour
{
    public AudioClip ChairBreaking;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Audio On");
        GetComponent<AudioSource>().PlayOneShot(ChairBreaking);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
