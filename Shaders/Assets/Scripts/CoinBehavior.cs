﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        BoxCollider col = gameObject.GetComponent<BoxCollider>();
	}

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }
}
