using UnityEngine;
using System.Collections;

public class Antigravity : MonoBehaviour {
    private Vector2 vector, otherVect;
    public float forceAmount;

    // Use this for initialization
    void Start()
    {
        vector = transform.position;
        Debug.Log(vector.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, 15f * Time.deltaTime); //Rotate blackhole
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            otherVect = other.transform.position;
            if (otherVect.x > vector.x)
            {
                other.GetComponent<Rigidbody2D>().AddForce(Vector2.right * forceAmount);
            }
            else
            {
                other.GetComponent<Rigidbody2D>().AddForce(Vector2.left * forceAmount);
            }
            if (otherVect.y > vector.y)
            {
                other.GetComponent<Rigidbody2D>().AddForce(Vector2.up * forceAmount);
            }
            else
            {
                other.GetComponent<Rigidbody2D>().AddForce(Vector2.down * forceAmount);
            }
            forceAmount = forceAmount * 1.01f;
        };
    }
}
