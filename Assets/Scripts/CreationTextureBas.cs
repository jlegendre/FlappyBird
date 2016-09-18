using UnityEngine;
using System.Collections;

public class CreationTextureBas : MonoBehaviour {

    public GameObject Obstacle;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("createTextureBas", 0f, 1f);
    }

    // Update is called once per frame
    void createTextureBas()
    {
        Instantiate(Obstacle);
    }
}

