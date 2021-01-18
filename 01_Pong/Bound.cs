using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
    	if(other.name != "Ball_Circle"){
    		return;
    	}

    	if(this.name == "West")
    	{
    		GameManager.Instance.GameOver(GameManager.State.LOSS);
    	}else
    	{
    		GameManager.Instance.GameOver(GameManager.State.WIN);
    	}
    }
}
