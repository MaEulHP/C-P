using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossClass : MonoBehaviour
{
    [SerializeField]
    public float Health = 100;
    [SerializeField]
    public enum enemyState
    {
        None = 0,
        Ready = 1,
        Move,
        AttackReady,
        Attack,
        Groggy,
        Death
    }
   
    void Start()
    {
        enemyState ES = enemyState.Ready;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
