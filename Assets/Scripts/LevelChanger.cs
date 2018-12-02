using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour {

    public Animator animator;

    private string levelToLoad;
    private GameManager man;

    private void Start()
    {
        man = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update () {

	}

    public void FadeToNextLevel(string level)
    {
        man.previousScene = SceneManager.GetActiveScene().name;
        man.newScene = level;
        FadeToLevel(level);
    }

    public void FadeToLevel(string level)
    {
        levelToLoad = level;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
