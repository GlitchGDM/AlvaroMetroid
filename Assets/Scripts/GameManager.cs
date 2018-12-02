using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public string previousScene;
    public string newScene;

    public bool is8A = false;

    private GameObject player;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    private void OnLevelWasLoaded(int level)
    {
        player = GameObject.Find("Player");
        if(SceneManager.GetActiveScene().name == "Scene1") //Spawnpoints en Scene1
        {
            if (previousScene == "Scene2")
            {
                GameObject spawn = GameObject.Find("SpawnpointScene2");
                player.transform.position = new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z);
            }
            else if (previousScene == "Scene9")
            {
                GameObject spawn = GameObject.Find("SpawnpointScene9");
                player.transform.position = new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z);
            }
        }
        else if (SceneManager.GetActiveScene().name == "Scene2") //Spawnpoints en Scene2
        {
            if (previousScene == "Scene1")
            {
                GameObject spawn = GameObject.Find("SpawnpointScene1");
                player.transform.position = new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z);
            }
            else if (previousScene == "Scene3")
            {
                GameObject spawn = GameObject.Find("SpawnpointScene3");
                player.transform.position = new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z);
            }
            else if (previousScene == "Scene4")
            {
                GameObject spawn = GameObject.Find("SpawnpointScene4");
                player.transform.position = new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z);
            }
        }
        else if(SceneManager.GetActiveScene().name == "Scene3") //Spawnpoints en Scene3
        {
            if (previousScene == "Scene2")
            {
                GameObject spawn = GameObject.Find("SpawnpointScene2");
                player.transform.position = new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z);
            }
        }
        else if (SceneManager.GetActiveScene().name == "Scene4") //Spawnpoints en Scene4
        {
            if (previousScene == "Scene2")
            {
                GameObject spawn = GameObject.Find("SpawnpointScene2");
                player.transform.position = new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z);
            }
            else if (previousScene == "Scene5")
            {
                GameObject spawn = GameObject.Find("SpawnpointScene5");
                player.transform.position = new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z);
            }
            else if (previousScene == "Scene9")
            {
                GameObject spawn = GameObject.Find("SpawnpointScene9");
                player.transform.position = new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z);
            }
            else if (previousScene == "Scene10")
            {
                GameObject spawn = GameObject.Find("SpawnpointScene10");
                player.transform.position = new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z);
            }
            else if (previousScene == "Scene11")
            {
                GameObject spawn = GameObject.Find("SpawnpointScene11");
                player.transform.position = new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z);
            }
        }
        else if (SceneManager.GetActiveScene().name == "Scene5") //Spawnpoints en Scene5
        {
            if (previousScene == "Scene4")
            {
                GameObject spawn = GameObject.Find("SpawnpointScene4");
                player.transform.position = new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z);
            }
            else if (previousScene == "Scene6")
            {
                GameObject spawn = GameObject.Find("SpawnpointScene6");
                player.transform.position = new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z);
            }
        }
        else if (SceneManager.GetActiveScene().name == "Scene6") //Spawnpoints en Scene6
        {
            if (previousScene == "Scene5")
            {
                GameObject spawn = GameObject.Find("SpawnpointScene5");
                player.transform.position = new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z);
            }
            else if (previousScene == "Scene7")
            {
                GameObject spawn = GameObject.Find("SpawnpointScene7");
                player.transform.position = new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z);
            }
        }
        else if (SceneManager.GetActiveScene().name == "Scene7") //Spawnpoints en Scene7
        {
            if (previousScene == "Scene6")
            {
                GameObject spawn = GameObject.Find("SpawnpointScene6");
                player.transform.position = new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z);
            }
            else if (previousScene == "Scene8" && is8A)
            {
                GameObject spawn = GameObject.Find("SpawnpointScene8a");
                player.transform.position = new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z);
            }
            else if (previousScene == "Scene8" && !is8A)
            {
                GameObject spawn = GameObject.Find("SpawnpointScene8b");
                player.transform.position = new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z);
            }
        }
        else if (SceneManager.GetActiveScene().name == "Scene8") //Spawnpoints en Scene8
        {
            if (previousScene == "Scene9")
            {
                GameObject spawn = GameObject.Find("SpawnpointScene9");
                player.transform.position = new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z);
            }
            else if (previousScene == "Scene7" && is8A)
            {
                GameObject spawn = GameObject.Find("SpawnpointScene7a");
                player.transform.position = new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z);
            }
            else if (previousScene == "Scene7" && !is8A)
            {
                GameObject spawn = GameObject.Find("SpawnpointScene7b");
                player.transform.position = new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z);
            }
        }
        else if (SceneManager.GetActiveScene().name == "Scene9") //Spawnpoints en Scene8
        {
            if (previousScene == "Scene8")
            {
                GameObject spawn = GameObject.Find("SpawnpointScene8");
                player.transform.position = new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z);
            }
            else if (previousScene == "Scene4")
            {
                GameObject spawn = GameObject.Find("SpawnpointScene4");
                player.transform.position = new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z);
            }
            else if (previousScene == "Scene1")
            {
                GameObject spawn = GameObject.Find("SpawnpointScene1");
                player.transform.position = new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z);
            }
        }
        else if (SceneManager.GetActiveScene().name == "Scene10") //Spawnpoints en Scene8
        {
            if (previousScene == "Scene3")
            {
                GameObject spawn = GameObject.Find("SpawnpointScene3");
                player.transform.position = new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z);
            }
            else if (previousScene == "Scene4")
            {
                GameObject spawn = GameObject.Find("SpawnpointScene4");
                player.transform.position = new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z);
            }
        }
        else if (SceneManager.GetActiveScene().name == "Scene11") //Spawnpoints en Scene8
        {
            if (previousScene == "Scene4")
            {
                GameObject spawn = GameObject.Find("SpawnpointScene4");
                player.transform.position = new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z);
            }
        }
    }

}
