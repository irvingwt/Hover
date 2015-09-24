using UnityEngine;
using System.Collections;

public class CamMovement : MonoBehaviour {
    private Vector3 mouse;
    private Vector3 targetPos;
    private Vector3 newPos;
    public GameObject target;
    public float topLeft;
    public float topRight;
    private float leftLimit = -150f;
    private float rightLimit = 150f;
    private bool launched;
    private Vector3 newPosition;

	// Use this for initialization
	void Start () {
        mouse.y = transform.position.y;
        newPosition = transform.position;
        newPos = transform.position;
        launched = false;
	}
	
	// Update is called once per frame
	void Update () {
        mouse.x = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        //mouse.z = -10;
        if (Input.GetMouseButtonUp(0))
        {
            launched = true;
        }
        if (mouse.x < leftLimit && leftLimit > topLeft && !launched) //Left movement
        {
            newPosition.x = newPosition.x - 10;
            transform.position = newPosition;
            leftLimit -= 10;
            rightLimit -= 10;
        }
        if (mouse.x > rightLimit && rightLimit < topRight && !launched) //Right movement
        {
            newPosition.x = newPosition.x + 10;
            transform.position = newPosition;
            leftLimit += 10;
            rightLimit += 10;
        }
        if (launched && GameObject.FindGameObjectWithTag("Player"))
        {
            targetPos = target.transform.position;
            newPos.x = targetPos.x;
            if (newPos.x > 0 && newPos.x < 520) {
                transform.position = newPos;
            }
            Debug.Log(target.transform.position);
        }
    }
}
