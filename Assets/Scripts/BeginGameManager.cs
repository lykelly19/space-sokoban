using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginGameManager : MonoBehaviour
{
    public Button button;

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
        // change scene to level 1
        SceneManager.LoadScene(sceneName: "Level1");
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
