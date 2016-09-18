using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public Button button;
    public Button buttonQuit;
    public static bool debut = false;
    // Use this for initialization
    void Start () {
        button.onClick.AddListener(() => { StartGame(); });
        buttonQuit.onClick.AddListener(() => { ExitGame(); });
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void StartGame()
    {
        SceneManager.LoadScene("Flappy Bird");
        debut = true;
    }

    void ExitGame()
    {
        Application.Quit();
    }
}
