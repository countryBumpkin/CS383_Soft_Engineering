using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPaddle : MonoBehaviour
{
	[Tooltip("Maximum speed of the AI Paddle")]
	public float speed = 10f;
	public enum Difficulty {Easy, Medium, Hard}

	[Header("AI Config")]
	[Tooltip("Sets the percentage of the ball speed that the AI Paddle moves at")]
	public Difficulty AI_Difficulty = Difficulty.Easy;
	public GameObject Ball;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    	if(Ball.GetComponent<Rigidbody2D>().velocity.x > 0)
    	{
	    	float posY = this.transform.position.y;
	    	float ballY = Ball.transform.position.y;
	        this.transform.position = new Vector3(this.transform.position.x, Mathf.MoveTowards(posY, ballY, CalculateSpeed() * Time.deltaTime), this.transform.position.z);
    	}
    }

    private float CalculateSpeed()
    {
    	if(AI_Difficulty == Difficulty.Easy)
    	{
    		speed = 0.4f * Ball.GetComponent<Rigidbody2D>().velocity.x;

    	}else if(AI_Difficulty == Difficulty.Medium)
    	{
    		speed = 0.5f * Ball.GetComponent<Rigidbody2D>().velocity.x;

    	}else{
    		speed = 0.8f * Ball.GetComponent<Rigidbody2D>().velocity.x;
    	}

    	return speed;
    }
}
