using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    private static GameManager gameManagerInstance;

    public string previousScene;
    public string newScene;

    public bool is8A = false;

    private GameObject player;

    public int actualShapeOnExit;

    public bool somethingBroke = false;
    public bool somethingBroke1 = false;

    bool brokenScene1 = false;
    bool brokenScene7 = false;
    bool brokenScene9a = false;
    bool brokenScene9b = false;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if (gameManagerInstance == null)
        {
            gameManagerInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (somethingBroke)
        {
            SaveBrokenStuff();
            
        }
    }

    void SaveBrokenStuff()
    {
        if (SceneManager.GetActiveScene().name == "Scene1")
        {
            brokenScene1 = true;
        }
        else if (SceneManager.GetActiveScene().name == "Scene7")
        {
            brokenScene7 = true;
        }
        else if(SceneManager.GetActiveScene().name == "Scene7")
        {
            if (somethingBroke)
            {
                brokenScene9a = true;
            }
            else if (somethingBroke1)
            {
                brokenScene9b = true;
            }
        }
        somethingBroke = false;
        somethingBroke1 = false;
    }

    private void OnLevelWasLoaded(int level)
    {
        player = GameObject.Find("Player");
        player.GetComponent<PlayerMovement>().actualShape = actualShapeOnExit;
        player.GetComponent<PlayerMovement>().ChangeShape();
        if (SceneManager.GetActiveScene().name == "Scene1") //Spawnpoints en Scene1
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
            if (brokenScene1)
            {
                Destroy(GameObject.Find("BreakableBlock"));
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
                if (GameObject.Find("Puerta"))
                {
                    Destroy(GameObject.Find("Puerta"));
                }
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
            if (brokenScene7)
            {
                Destroy(GameObject.Find("BreakableBlock"));
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
        else if (SceneManager.GetActiveScene().name == "Scene9") //Spawnpoints en Scene9
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

            if (brokenScene1)
            {
                Debug.Log("Destruido");
                Destroy(GameObject.Find("BreakableBlock"));
            }
            else if (brokenScene9a)
            {
                Destroy(GameObject.Find("BreakableBlock"));
            }
            else if (brokenScene9b)
            {
                Destroy(GameObject.Find("BreakableBlock1"));
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
