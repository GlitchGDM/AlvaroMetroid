using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public string previousScene;
    public string newScene;

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
        }
        else if (SceneManager.GetActiveScene().name == "Scene5") //Spawnpoints en Scene4
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
        else if (SceneManager.GetActiveScene().name == "Scene6") //Spawnpoints en Scene4
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
    }

}
