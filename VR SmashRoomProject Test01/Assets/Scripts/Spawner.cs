using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //for setting the spawn time
    public float Spawn_Wait;
    public float Spawn_Most_Wait;
    public float Spawn_Least_Wait;
    public int Start_Wait;
    //storing the breakable objects into array
    public GameObject[] Break_Object_Prefab;
    // Start is called before the first frame update
    void Start()
    {
        //spawning 
        StartCoroutine(Spawn_Object());
    }


    // Update is called once per frame
    void Update()
    {
        //randomise spawn time using range
        Spawn_Wait = Random.Range(Spawn_Least_Wait, Spawn_Most_Wait);
    }

    IEnumerator Spawn_Object()
    {
        yield return new WaitForSeconds(Start_Wait);

        while (true)
        {
            //selecting the breakable objects randomly 
            GameObject go = Instantiate(Break_Object_Prefab[Random.Range(0, Break_Object_Prefab.Length)]);
            Rigidbody temp = go.GetComponent<Rigidbody>();
            //position which the object is going to get thrown
            temp.velocity = new Vector3(0f, 5f, -5f);
            temp.useGravity = true;
            //position which the object is going to spawn(starting position)
            Vector3 pos = transform.position;
            pos.x += Random.Range(0f, 0f);
            go.transform.position = pos;
            //wait time for next object to get spawn
            yield return new WaitForSeconds(Spawn_Wait);

        }
    }

}

