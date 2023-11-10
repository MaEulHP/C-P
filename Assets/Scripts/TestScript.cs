using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    Rigidbody2D rb;
    //move
    float moveDir;
    float moveSpeed = 5f;
    float jumpPower = 5f;
    bool isGrounded = true;

    //C&P
    bool canParry = true;
	public int counter_Token = 1;
	public float counter_Gauge = 0.0f;

    //Status
    public float health = 100f;

	void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
    }

    void Start()
    {
        
    }
   
    private void FixedUpdate()
    {
		//Move by Key Input
		moveDir = Input.GetAxisRaw("Horizontal");
		if ((Input.GetKeyDown(KeyCode.Space)) && (isGrounded))
		{
			rb.velocity += new Vector2(0, jumpPower);
			Debug.Log("Jump");
		}
		transform.Translate(moveDir * Time.fixedDeltaTime * moveSpeed, 0, 0);

		if (Input.GetKeyDown(KeyCode.Z)) //Attack
		{

		}
		if (Input.GetKey(KeyCode.X)) //Guard
		{
			StartCoroutine("parryingOff");
			if (canParry)
			{
				//Success Parrying 
			}
			else
			{
				//-70% Damage Trigger by Each Pattern
			}
		}
		if (Input.GetKeyUp(KeyCode.X))
		{
			StopCoroutine("parryingOff");
			canParry = true;
		}

		//Counter Token and Gauge Management
		if (counter_Gauge <= 100f)
		{
			counter_Gauge += 0.005f;
		}
		else
		{
			if (counter_Token < 2)
			{
				counter_Token++;
				counter_Gauge -= 100f;
				Debug.Log("Counter Token 1 up");
			}
			else if (counter_Token == 2)
			{
				counter_Gauge = 100f;
			}
		}
	}
	//Coroutine
	IEnumerator parryingOff()
	{
		yield return WaitForSeconds(0.5f);
		canParry = false;
		Debug.Log("Disable Parry");
	}


	void Attack()
    {

    }
    void OnCollisionEnter2D(Collision2D collider)
    {
        GameObject go = collider.gameObject;
        if (go.tag == "Ground")
        {
			isGrounded = true;
		}
        else if(go.tag == "Enemy")
        {
            Enemy enemy = go.GetComponent<Enemy>;
			if (enemy != null)
			{
				int enemyState = enemy.enemyState;
			}
            if (enemyState == 4)
            {
				//Damage Trigger by Each pattern
			}

		}

    }
    void OnCollisionExit2D(Collision2D collider)
    {
		GameObject go = collider.gameObject;
		if (go.tag == "Ground")
		{
			isGrounded = false;
		}
        
	}
}
