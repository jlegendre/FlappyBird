﻿using UnityEngine;
using System.Collections;

public class CreationTunnel : MonoBehaviour {

    public GameObject Obstacle;
    int x;

	// Use this for initializationn
	void Start () {
        InvokeRepeating("createTunnel", 1.5f, 1.5f);
	}
	
	// Update is called once per frame
	void createTunnel()
    {
        Instantiate(Obstacle).transform.position += new Vector3(0,x,0);
        RandomMethod();
    }

    void RandomMethod()
    {
        x = Random.Range(0, 4);
       
    }
}
