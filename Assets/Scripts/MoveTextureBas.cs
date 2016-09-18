using UnityEngine;
using System.Collections;

public class MoveTextureBas : MonoBehaviour {

    Vector2 vitesse = new Vector2(-2.5f, 0);
    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = vitesse;
    }

    // Update is called once per frame
    void Update()
    {

    }
}