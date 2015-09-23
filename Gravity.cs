using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Gravity : MonoBehaviour {
    private Vector2 vector, otherVect;
    private int veces;
    public float forceAmount;

	// Use this for initialization
	void Start () {
        vector = transform.position;
        Debug.Log(vector.ToString());
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerStay2D(Collider2D other){
        if (other.gameObject.tag == "Player"){
            otherVect = other.transform.position;
            if (otherVect.x > vector.x){
                other.GetComponent<Rigidbody2D>().AddForce(Vector2.left * forceAmount);
            } else {
                other.GetComponent<Rigidbody2D>().AddForce(Vector2.right * forceAmount);
            }
            if (otherVect.y > vector.y){
                other.GetComponent<Rigidbody2D>().AddForce(Vector2.down * forceAmount);
            } else {
                other.GetComponent<Rigidbody2D>().AddForce(Vector2.up * forceAmount);
            }
            forceAmount = forceAmount * 1.1f;
            if (otherVect.x < vector.x + 1 && otherVect.y < vector.y + 1 && forceAmount > 30000){
                Destroy(other.gameObject);
            };
        };
        veces++;
    }

}
