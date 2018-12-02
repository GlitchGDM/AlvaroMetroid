using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTrigger : MonoBehaviour {

    public LevelChanger lChanger;

    public string levelToLoad;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        lChanger.FadeToNextLevel(levelToLoad);
    }
}
