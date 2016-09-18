using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public Button button;
    public static bool debut = false;
    // Use this for initialization
    void Start () {
        button.onClick.AddListener(() => { StartGame(); });
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void StartGame()
    {
        SceneManager.LoadScene("Flappy Bird");
        debut = true;
    }

}
