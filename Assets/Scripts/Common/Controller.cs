using System;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public void ResumeGame(){
        // TODO ADD RESUME GAME
    }

    public void SelectCharacters(){
        // TODO ADD CHARACTER SELECTION MENU
    }

    public void RedirectToGitHub()
    {
        Application.OpenURL("https://github.com/NichoBrando/Lambiris");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
