using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VibrationManager : MonoBehaviour
{

    //public class VibrationManager singleton;

    // Start is called before the first frame update
    void Start()
    {

        //if (singleton && singleton != this)
          //  Destroy(this);
       // else singleton = this;

    }

    // Update is called once per frame
    public void TriggerVibration(AudioClip vibrationAudio, OVRInput.Controller controller)
    {

        //OVRHapticsClip clip = new OVRHapticsClip(vibrationAudio);

       // if(controller == OVRInput.Controller.LTouch)
        {
            //Trigeer Left Controller
         //   OVRHaptics.LeftChannel.Preempt(clip);
        }

       // else if (controller == OVRInput.Controller.RTouch)
        {
            //Trigger Right Controller
         //   OVRHaptics.RightChannel.Preempt(clip);
        }
    }
}
