using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour {

    // Use this for initialization
    public float speed;
    public float jump;
    public GameObject palomo;
    //public float rayCheckDistance;
    Rigidbody2D rb;
	void Start () {
        rb = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal");
        transform.position += new Vector3(x * speed * Time.deltaTime, 0, 0);
        float y = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, y * jump * Time.deltaTime, 0);
        
        
    }
}
