using UnityEngine;
using System.Collections;

public class MouvementTunnel : MonoBehaviour {

    Vector2 vitesse = new Vector2(-2.5f, 0);
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = vitesse;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Cube")
        {
            Destroy(this.gameObject);
        }
    }
}
