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
    public bool pickUpUp = false;

    bool brokenScene1 = false;
    bool pickUpScene5 = false;
    bool brokenScene7 = false;
    bool pickUpScene7 = false;
    bool pickUpScene8 = false;
    bool brokenScene9a = false;
    bool brokenScene9b = false;
    bool pickUpScene9 = false;
    bool pickUpScene10 = false;
    bool pickUpScene11 = false;

    bool scene2Seen = false;
    bool scene3Seen = false;
    bool scene4Seen = false;
    bool scene5Seen = false;
    bool scene6Seen = false;
    bool scene7Seen = false;
    bool scene8Seen = false;
    bool scene9Seen = false;
    bool scene10Seen = false;
    bool scene11Seen = false;

    int x = 0;

    public bool pickUp1Acquired = false;
    public bool pickUp2Acquired = false;
    public bool pickUp3Acquired = false;
    public int numberStars = 0;

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
        if (somethingBroke || somethingBroke1 || pickUpUp)
        {
            SaveBrokenStuff();
        }
        Debug.Log(numberStars);
        if (numberStars == 5)
        {
            GameObject.Find("Victory").GetComponent<SpriteRenderer>().enabled = true;
        }

    }

    void SaveBrokenStuff()
    {
        if (SceneManager.GetActiveScene().name == "Scene1")
        {
            brokenScene1 = true;
        }
        else if (SceneManager.GetActiveScene().name == "Scene5")
        {
            pickUpScene5 = true;
        }
        else if (SceneManager.GetActiveScene().name == "Scene7")
        {
            if (somethingBroke)
            {
                brokenScene7 = true;
            }
            if (pickUpUp)
            {
                pickUpScene7 = true;
            }
        }
        else if (SceneManager.GetActiveScene().name == "Scene8")
        {
            pickUpScene8 = true;
        }
        else if(SceneManager.GetActiveScene().name == "Scene9")
        {
            if (somethingBroke)
            {
                brokenScene9a = true;
            }
            if (somethingBroke1)
            {
                brokenScene9b = true;
            }
            if (pickUpUp)
            {
                pickUpScene9 = true;
            }
        }
        else if (SceneManager.GetActiveScene().name == "Scene10")
        {
            pickUpScene10 = true;
        }
        else if (SceneManager.GetActiveScene().name == "Scene11")
        {
            pickUpScene11 = true;
        }

        somethingBroke = false;
        somethingBroke1 = false;
        pickUpUp = false;
    }

    private void OnLevelWasLoaded(int level)
    {
        player = GameObject.Find("Player");
        player.GetComponent<PlayerMovement>().actualShape = actualShapeOnExit;
        player.GetComponent<PlayerMovement>().ChangeShape();
        if (SceneManager.GetActiveScene().name == "Scene1") //Spawnpoints en Scene1
        {
            x = 0;
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
            if (brokenScene9a)
            {
                Destroy(GameObject.Find("BreakableBlock"));
            }
        }
        else if (SceneManager.GetActiveScene().name == "Scene2") //Spawnpoints en Scene2
        {
            if (!scene2Seen)
            {
                scene2Seen = true;
            }
            x = 0;

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
            if (!scene3Seen)
            {
                scene3Seen = true;
            }
            x = 0;

            if (previousScene == "Scene2")
            {
                GameObject spawn = GameObject.Find("SpawnpointScene2");
                player.transform.position = new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z);
            }
        }
        else if (SceneManager.GetActiveScene().name == "Scene4") //Spawnpoints en Scene4
        {
            if (!scene4Seen)
            {
                scene4Seen = true;
            }
            x = 0;

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
            if (!scene5Seen)
            {
                scene5Seen = true;
            }
            x = 0;

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
            if (pickUpScene5)
            {
                Destroy(GameObject.Find("PickUp"));
            }
        }
        else if (SceneManager.GetActiveScene().name == "Scene6") //Spawnpoints en Scene6
        {
            if (!scene6Seen)
            {
                scene6Seen = true;
            }
            x = 0;

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
            if (!scene7Seen)
            {
                scene7Seen = true;
            }
            x = 0;

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
            if (pickUpScene7)
            {
                Destroy(GameObject.Find("PickUp"));
            }
        }
        else if (SceneManager.GetActiveScene().name == "Scene8") //Spawnpoints en Scene8
        {
            if (!scene8Seen)
            {
                scene8Seen = true;
            }
            x = 0;

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
            if (pickUpScene8)
            {
                Destroy(GameObject.Find("PickUp"));
            }
        }
        else if (SceneManager.GetActiveScene().name == "Scene9") //Spawnpoints en Scene9
        {
            if (!scene9Seen)
            {
                scene9Seen = true;
            }
            x = 0;

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
                Destroy(GameObject.Find("BreakableBlock"));
            }
            if (brokenScene9a)
            {
                Destroy(GameObject.Find("BreakableBlock"));
            }
            if (brokenScene9b)
            {
                Destroy(GameObject.Find("BreakableBlock1"));
            }
            if (pickUpScene9)
            {
                Destroy(GameObject.Find("PickUp"));
            }
        }
        else if (SceneManager.GetActiveScene().name == "Scene10") //Spawnpoints en Scene10
        {
            if (!scene10Seen)
            {
                scene10Seen = true;
            }
            x = 0;

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
            if (pickUpScene10)
            {
                Destroy(GameObject.Find("PickUp"));
            }
        }
        else if (SceneManager.GetActiveScene().name == "Scene11") //Spawnpoints en Scene8
        {
            if (!scene11Seen)
            {
                scene11Seen = true;
            }
            x = 0;

            if (previousScene == "Scene4")
            {
                GameObject spawn = GameObject.Find("SpawnpointScene4");
                player.transform.position = new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z);
            }
            if (pickUpScene11)
            {
                Destroy(GameObject.Find("PickUp"));
            }
        }
    }

    public void CheckMap()
    {
        if(x == 0)
        {
            if (scene2Seen)
            {
                Destroy(GameObject.Find("2"));
            }
            if (scene3Seen)
            {
                Destroy(GameObject.Find("3"));
            }
            if (scene4Seen)
            {
                Destroy(GameObject.Find("4"));
            }
            if (scene5Seen)
            {
                Destroy(GameObject.Find("5"));
            }
            if (scene6Seen)
            {
                Destroy(GameObject.Find("6"));
            }
            if (scene7Seen)
            {
                Destroy(GameObject.Find("7"));
            }
            if (scene8Seen)
            {
                Destroy(GameObject.Find("8"));
            }
            if (scene9Seen)
            {
                Destroy(GameObject.Find("9"));
            }
            if (scene10Seen)
            {
                Destroy(GameObject.Find("10"));
            }
            if (scene11Seen)
            {
                Destroy(GameObject.Find("11"));
            }
        }  
        x++;
    }

}
