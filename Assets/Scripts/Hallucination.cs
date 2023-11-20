using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hallucination : MonoBehaviour
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
    bool isAE = false;
    int aeEnable = 1;
    void Start()
    {
        enemyState = 1; 
    }

    void Update()
    {
        if (aeEnable < 1){
            DestroyAll();
        }
        
    }
    void makeAlterEgo(GameObject go){

    }

}
