using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass : MonoBehaviour
{

    public Rigidbody player_rigidbody;
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move by keyboard
        float translation = Input.GetAxis("Vertical") * speed;
        translation *= Time.deltaTime;

        if ((Input.GetKey(KeyCode.Space))||(Input.GetKey(KeyCode.W)))
        {
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.DownArrow)||Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0,0,-1) * Time.deltaTime * speed);
        }

        if(Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime*speed);
        }

        if( Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speed);
        }    
    }
}
