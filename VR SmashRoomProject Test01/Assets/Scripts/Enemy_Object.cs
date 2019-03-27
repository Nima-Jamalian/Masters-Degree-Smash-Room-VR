using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Object : MonoBehaviour
{
    //public AudioSource  sound_effect;
    public bool has_hit = false;
    [SerializeField]
    private GameObject Sparkel_Effect;

    private void Update()
    {
        // sound_effect = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!has_hit & collision.gameObject.CompareTag("Bat"))
        {
            GameController.health -= 1;
            Instantiate(Sparkel_Effect, transform.position, Quaternion.identity);
            //sound_effect.Play();
            Destroy(gameObject);
            has_hit = true;
            
            //Debug.Log("hit");
        }
        if (collision.gameObject.CompareTag("Floor"))
        {
            Destroy(gameObject);
            //Debug.Log("hit");
        }
    }
}
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Object : MonoBehaviour
{
    //public AudioSource  sound_effect;
    public bool has_hit = false;
    public int graceTime = 3;
    //[SerializeField]
   // private GameObject Sparkel_Effect;

    private void Update()
    {
        // sound_effect = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        //switch (collision.gameObject.tag)
        //{
        //    case "Bat":
                if (!has_hit && collision.gameObject.tag == "Bat")
                {
                    GameController.health--;
            StartCoroutine(GraceTimer());
           
            has_hit = false;
            Destroy(gameObject);
            Debug.Log(has_hit);

            Debug.Log("i hit the black ball" + GameController.health);
                }
                //break;
        }
    IEnumerator GraceTimer()
    {
        yield return new WaitForSeconds(graceTime);


        while(true)
        {
            has_hit = true;
        }
    }
    }
    */
/*
if (!has_hit & collision.gameObject.CompareTag("Bat"))
{
GameController.health -= 1;
//Instantiate(Sparkel_Effect, transform.position, Quaternion.identity);
// sound_effect.Play();
Destroy(gameObject);
has_hit = true;
//Debug.Log("hit");
}
if (collision.gameObject.CompareTag("Floor"))
{
Destroy(gameObject);
//Debug.Log("hit");
}
}
*/

/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Object : MonoBehaviour
{
    public bool has_hit = false;

    private void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!has_hit & collision.gameObject.CompareTag("Bat"))
        {
            GameController.health -= 1;
            Destroy(gameObject);
            has_hit = true;
            //Debug.Log("hit");
        }
        if (collision.gameObject.CompareTag("Floor"))
        {
            Destroy(gameObject);
            //Debug.Log("hit");
        }
    }
}*/
