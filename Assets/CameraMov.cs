using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour {
    public GameObject palomo;
    private Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = transform.position - palomo.transform.position;

    }
	
	// Update is called once per frame
	void Update () {
        transform.position = palomo.transform.position + offset;
    }
}
