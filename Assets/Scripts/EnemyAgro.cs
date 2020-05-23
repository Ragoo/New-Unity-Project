using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAgro : MonoBehaviour
{
    public float dangerDistance;

    public GameObject enemy;
    private GameManager gm;

    private void Start()
    {
        gm = GetComponentInParent<GameManager>();
    }

    void ProximityCheck()
    {
        float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);

            if (distanceToEnemy < dangerDistance)
            {
            gm.enemyFollowsPlayer = true;

            }

        

    }

    void Update()
    {
        ProximityCheck();
        
    }
}
