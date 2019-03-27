using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuUIController : MonoBehaviour {
    public Button B_NewGame, B_LoadGame, B_Exit;

    public void B_NewGameOnClick()
    {
       //scenemanagement new scene
    }

    public void B_LoadGameOnClick()
    {
        //load game from save files (not implemented yet)
    }

    public void B_ExitOnClick()
    {
        Application.Quit();
    }

}
