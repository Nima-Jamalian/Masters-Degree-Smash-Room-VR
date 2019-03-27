using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    public float speed;
    Vector3 temp;
    void Start()
    {

    }
    void Update()
    {
        temp = transform.localScale;
        if (temp.x < 10)
        {
            temp.x += Time.deltaTime * speed;
            temp.y += Time.deltaTime * speed;
            temp.z += Time.deltaTime * speed;
            transform.localScale = temp;
        }
    }
    /*
    Vector3 Min_Scale;
    public Vector3 Max_Scale;
    public bool Repeatable;
    public float Speed;
    public float Duration;

    IEnumerator Start ()
    {
        Min_Scale = transform.localScale;
        while (Repeatable)
        {
            yield return RepeatLerp(Min_Scale, Max_Scale, Duration);
            yield return RepeatLerp(Max_Scale, Min_Scale, Duration);
        }
    }
     public IEnumerator RepeatLerp(Vector3 a, Vector3 b, float time)
    {
        float i = 0.0f;
        float rate = (1.0f / time) * Speed;
        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            transform.localScale = Vector3.Lerp(a, b, i);
            yield return null;
        }
    }
    */

}
