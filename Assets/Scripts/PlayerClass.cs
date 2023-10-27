using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//enum State = {"Ready", "Attack", "Guard", "Death"};

public class PlayerClass : MonoBehaviour
{

    public Rigidbody2D player_rigidbody;
    public float speed = 5f;
    public GameObject bottom ;
    //public State player_State = 0;

    void Awake()
    {
        player_rigidbody = GetComponent<Rigidbody2D>();
        player_rigidbody.freezeRotation = true;
    }

    public int counter_Token = 2;
    public float counter_Gauge = 0.0f;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move by Key Input
        float translation = Input.GetAxis("Vertical") * speed;
        translation *= Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            player_rigidbody.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector2(-1, 0) * Time.deltaTime*speed);
        }

        if( Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector2(1, 0) * Time.deltaTime * speed);
        }

        //Counter Token and Gauge Management
        if(counter_Gauge <= 100) {
            counter_Gauge += 0.01f;
        }
        else {
            if(counter_Token < 2){
                counter_Token++;
                counter_Gauge -= 100;
            }
        }   
    }

    void Attack()
    {

    }
}
