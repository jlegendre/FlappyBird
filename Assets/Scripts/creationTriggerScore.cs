using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class creationTriggerScore : MonoBehaviour {

    public Text hightScore;
    public Text score;
    public GameObject Obstacle;
    private int Hight_score = 0;
    int x;
    public static int i;

    
    // Use this for initialization
    void Start()
    {
        
        i = 0;
        InvokeRepeating("createtriggerScore", 6f, 1.5f);
        
    }

    // Update is called once per frame
    void createtriggerScore()
    {
        Instantiate(Obstacle);
        
        i++;
        score.text = "" + i;
       


        if (PlayerPrefs.GetInt("HightScore") < i)
        {
            Hight_score = i;
            PlayerPrefs.SetInt("HightScore",Hight_score);
        } 
    }
    
    
}