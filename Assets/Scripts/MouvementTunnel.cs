﻿using UnityEngine;
using System.Collections;

public class MouvementTunnel : MonoBehaviour {

    public Vector2 vitesse = new Vector3(0, 0);
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = vitesse;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
