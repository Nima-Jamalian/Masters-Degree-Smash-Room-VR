using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obsticale"))
        {
            Score.scoreValue += 1;
            //Debug.Log("hit");
        }
    }
}

