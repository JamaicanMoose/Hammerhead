using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRPlayerModel : MonoBehaviour {
    public Transform trackedHeadPos;
    public Transform modelHeadPos;
    public Transform trackedLHandPos;
    public Transform modelLHandPos;
    public Transform trackedRHandPos;
    public Transform modelRHandPos;
	// Use this for initialization
	void Start () {
        modelHeadPos.SetParent(trackedHeadPos);
        modelLHandPos.SetParent(trackedLHandPos);
        modelRHandPos.SetParent(trackedRHandPos);
	}
	
	// Update is called once per frame
	void Update () {
        //modelHeadPos.SetPositionAndRotation(trackedHeadPos.position, trackedHeadPos.rotation);
        //modelLHandPos.SetPositionAndRotation(trackedLHandPos.position, trackedLHandPos.rotation);
        //modelRHandPos.SetPositionAndRotation(trackedRHandPos.position, trackedRHandPos.rotation);
	}
}
