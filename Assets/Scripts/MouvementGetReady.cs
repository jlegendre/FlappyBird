using UnityEngine;
using System.Collections;

public class MouvementGetReady : MonoBehaviour {

    Vector2 vitesse = new Vector2(-1.5f, 0);
    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = vitesse;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1)
        {
            gameObject.SetActive(false);

        }

    }
}