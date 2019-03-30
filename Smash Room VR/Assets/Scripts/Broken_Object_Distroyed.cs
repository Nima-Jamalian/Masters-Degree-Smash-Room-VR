using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broken_Object_Distroyed : MonoBehaviour
{
    IEnumerator DestroySelf()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroySelf());
    }

    // Update is called once per frame
    void Update()
    {

    }
}

