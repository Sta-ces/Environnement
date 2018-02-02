using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public Canvas m_Menu;


    public void QuitApplication()
    {
        Application.Quit();
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
            m_Menu.gameObject.SetActive(!m_Menu.gameObject.activeSelf);
	}
}
