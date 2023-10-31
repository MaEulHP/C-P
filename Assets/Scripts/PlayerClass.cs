using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//enum State = {"Ready", "Attack", "Guard", "Death"};

public class PlayerClass : MonoBehaviour
{

    Rigidbody2D rb;

    float moveDir;
    public float moveSpeed = 250f;
    public float jumpPower = 5f;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
    }

    public int counter_Token = 2;
    public float counter_Gauge = 0.0f;

    public enum PlayerState
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveDir = Input.GetAxisRaw("Horizontal");
        //Move by Key Input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity += new Vector2(0, jumpPower);
        }

        if (Input.GetKey(KeyCode.Z)) //Attack
        {
             
        }
        if (Input.GetKey(KeyCode.X)) //Guard
        {

        }

        //Counter Token and Gauge Management
        if (counter_Gauge <= 100) {
            counter_Gauge += 0.01f;
        }
        else {
            if(counter_Token < 2){
                counter_Token++;
                counter_Gauge -= 100;
            }
        }   
    }
    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(moveDir * Time.fixedDeltaTime * moveSpeed, rb.velocity.y));
    }

    void Attack()
    {

    }
}
