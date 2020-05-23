using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public GameObject followTarget;

    void Start()
    {

    }


    void FixedUpdate()
    {

        if (followTarget)
        {
            float step = 5f * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, followTarget.transform.position, step);


        }
    }
}
