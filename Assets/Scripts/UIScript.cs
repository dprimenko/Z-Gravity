using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class UIScript : MonoBehaviour {

    public void ClickRestart() {
        SceneManager.LoadScene("main");

    }

    public void ClickExit() {
        Application.Quit();
    }
}
