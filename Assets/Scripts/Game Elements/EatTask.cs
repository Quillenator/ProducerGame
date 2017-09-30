using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatTask : MonoBehaviour {

    [SerializeField]
    private bool canEat;

	
    // Use this for initialization
	void Start () {
		
	}
	
    void OnCollisionEnter(Collision col)
    {
        print("Collided with... " + col.gameObject.name);
        
        if(canEat && col.gameObject.name == "Task")
        {
            col.gameObject.SetActive(false);
        }
    }
}
