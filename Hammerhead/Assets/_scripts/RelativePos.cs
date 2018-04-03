using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelativePos : MonoBehaviour {

    public Transform headPos;
    public Transform handPos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 headtohand = (handPos.position - headPos.position).normalized;
        headtohand *= 2.0f;
        transform.position = headtohand;
        transform.rotation = handPos.rotation;
	}
}
