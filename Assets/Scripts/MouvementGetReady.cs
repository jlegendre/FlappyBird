using UnityEngine;
using System.Collections;

public class MouvementGetReady : MonoBehaviour {
    float timeLeft = 3.0f;
    public CanvasGroup canvas;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(DoFade());
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;

    }

    IEnumerator DoFade()
    {
        while (canvas.alpha > 0)
        {
            canvas.alpha = timeLeft - Time.deltaTime;
            yield return null;
        }

        canvas.interactable = false;
        yield return null;
    }
}