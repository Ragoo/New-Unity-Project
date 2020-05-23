using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public bool enemyFollowsPlayer;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (enemyFollowsPlayer) 
        {
            enemy.GetComponent<EnemyFollow>().followTarget = player;
        }
    }
}
