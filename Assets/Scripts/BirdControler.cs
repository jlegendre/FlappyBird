using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BirdControler : MonoBehaviour {

    public Vector2 forceSaut = new Vector2(0, 600);

    public AudioClip clipvideo;
    public AudioSource source;

    public AudioClip clipvideoGameOver;
    public AudioSource sourceGameOver;

    public Button button;
    public Canvas canvasReplay;
    public Text hightScoreText;
    public Text scoreText;


    // Use this for initialization
    void Start () {

        source = GetComponent<AudioSource>();
        sourceGameOver = GetComponent<AudioSource>();

        canvasReplay.enabled = false;
        Time.timeScale = 1;
        button.onClick.AddListener(() => { restartGame(); });


    }
	
	// Update is called once per frame
	void Update () {
       
        // lorsque l'on appuie sur la touche Espace ou qu'on appui sur l'écran(sous Android)
        // on ajoute une forceSaut et on joue la musique du saut
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetTouch(0).phase == TouchPhase.Began)
        {
            GetComponent<Rigidbody2D>().AddForce(forceSaut);
            source.clip = clipvideo;
            source.Play();
        }
   //     Vector2 positionCamera = Camera.main.WorldToScreenPoint(transform.position);

   //     if (positionCamera.y > Screen.height || positionCamera.y < 0){
   //         KillBird();
   //     }
   }

    // lorsqu'on entre en collision avec un rigidbody 2D on affiche le canvas pour le score
    // et on joue la musique Game Over.
    void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.name == "plafond") { }
        else
        {
            //
            sourceGameOver.clip = clipvideoGameOver;
            sourceGameOver.Play();

            hightScoreText.text = "" + PlayerPrefs.GetInt("HightScore");
            scoreText.text = "" + creationTriggerScore.i;
            canvasReplay.enabled = true;
            Time.timeScale = 0;
        }
    }

    void restartGame() {
        SceneManager.LoadScene("Flappy Bird");
    }
}
