using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShatterOnCollision : MonoBehaviour
{

    public GameObject replacement;
    public GameObject initialGO;

    private OVRGrabbable ovrGrabbable;
  //  public AudioClip BreakingAudio;

    public bool hasBroken = false;

    void Start()
    {
        ovrGrabbable = GetComponent<OVRGrabbable>();
    }

    void OnCollisionEnter(Collision collision) 
    {
        switch (collision.gameObject.tag)
        {
            case"Bat":
                if (!hasBroken)
                {
                    GameObject.Instantiate(replacement, transform.position, transform.rotation);
                    Destroy(gameObject);
                    hasBroken = true;
                }
                break;
            case "Floor":
                Destroy(gameObject);
                break;
        }



        
        // GetComponent<AudioSource>().PlayOneShot(BreakingAudio);

        // OVRInput.SetControllerVibration(0.5f, 0.5f, ovrGrabbable.grabbedBy.GetController());

        //VibrationManager.singleton.TriggerVibration(ChairBreaking, ovrGrabbable.grabbedBy.GetController);

    }

    void Update()
   {
       //GetComponent<AudioSource>().PlayOneShot(BreakingAudio);
       

    }
}
