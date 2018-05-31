using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0f, 0f, 1f));
    }

    protected virtual void OnTriggerEnter2D(Collider2D collider)
    { 

        Character character = collider.GetComponent<Character>();

        if (character)
        {
            character.ReceiveDamage();
        }

        Bullet bullet = collider.gameObject.GetComponent<Bullet>();
        if (bullet && bullet.Parent != gameObject)
        {
            Destroy(bullet);
        }
    }

    
}
