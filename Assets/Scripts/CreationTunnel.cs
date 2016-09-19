using UnityEngine;
using System.Collections;

public class CreationTunnel : MonoBehaviour {

    public GameObject Obstacle;
    float x;

	// Use this for initializationn
	void Start () {
        InvokeRepeating("createTunnel", 0, 1.5f);
	}
	
	// Update is called once per frame
	void createTunnel()
    {
        Instantiate(Obstacle).transform.position += new Vector3(0,x,0);
        RandomMethod();
    }

    void RandomMethod()
    {
        x = Random.Range(-2.75f, 2.25f);
       
    }
    

}
