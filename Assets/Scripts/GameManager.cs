using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Button button;
    private Scene scene;

    void Start() 
    {
        // get the current scene 
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        // if the level has been completed, change the scene
        bool complete = IsLevelComplete();
        if (complete) 
            ChangeScene();

        // if the restart button has been clicked, load the current scene again
        bool restartLevel = IsButtonClicked();
        if (restartLevel)
            SceneManager.LoadScene(scene.name);

    }

    void ChangeScene() 
    {
        // change to next level completed scene based on current scene
        if(scene.name == "Level1")
            SceneManager.LoadScene(sceneName: "Level1Completed");

        if(scene.name == "Level2")
            SceneManager.LoadScene(sceneName: "Level2Completed");
    }

    bool IsLevelComplete() 
    {
        // create array of Target objects (diamonds)
        Target[] targets = FindObjectsOfType<Target>();

        // iterate through targets, if there is no overlap from a box on one of them, return false
        foreach (var target in targets)
            if (!target.overlap) 
                return false;

        return true;
    }

    bool IsButtonClicked() 
    {
        button = (Button)FindObjectOfType(typeof(Button));

        // check if button has been pressed
        if(button.isPressed)
            return true;

        return false;
    }
}
