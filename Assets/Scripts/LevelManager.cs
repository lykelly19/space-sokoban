using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public Button button;
    private Scene scene;

    // Update is called once per frame
    void Update()
    {
        bool sceneComplete = IsButtonClicked();

        // if button to continue has been clicked, continue to next scene 
        if (sceneComplete) 
            ChangeScene();
    }

    void ChangeScene() 
    {
        // get the current scene 
        scene = SceneManager.GetActiveScene();

        // change to next level completed scene based on current scene
        if(scene.name == "Level1Completed")
            SceneManager.LoadScene(sceneName: "Level2");

        if(scene.name == "Level2Completed")
            SceneManager.LoadScene(sceneName: "StartScreen");
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
