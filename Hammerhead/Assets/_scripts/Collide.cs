using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collide : MonoBehaviour {

    public Text winText;

    void Start()
    {
        winText.text = "";

    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "trigger")
        {
            winText.text = "Solved!";
        }
    }
}
