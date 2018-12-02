using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTrigger : MonoBehaviour {

    public LevelChanger lChanger;

    public string levelToLoad;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().actualShapeOnExit = GameObject.Find("Player").GetComponent<PlayerMovement>().actualShape;
        Debug.Log(GameObject.Find("GameManager").GetComponent<GameManager>().actualShapeOnExit);
        if (gameObject.name == "LevelChangeScene8a" || gameObject.name == "LevelChangeScene7a")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().is8A = true;
        }
        else if (gameObject.name == "LevelChangeScene8b" || gameObject.name == "LevelChangeScene7b")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().is8A = false;
        }  
        lChanger.FadeToNextLevel(levelToLoad);
    }
}
