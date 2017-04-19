using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject loadMenu;

    public Animator anim;
    public Image fadeImage;

    public void HideMainMenu() {
        mainMenu.SetActive(false);
    }

    public void ShowMainMenu() {
        mainMenu.SetActive(true);
    }

    public void ContinueGame() {
        Debug.Log("Continue");
    }

    public void ShowOptionsMenu() {
        HideMainMenu();
        optionsMenu.SetActive(true);
    }

    public void HideOptionsMenu() {
        optionsMenu.SetActive(false);
        ShowMainMenu();
    }

    public void QuitGame() {
        fadeImage.raycastTarget = true;
        anim.SetTrigger("FadeOut");
        //Application.Quit();
        Invoke("Quit", 1f);
    }

    void Quit() {
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
