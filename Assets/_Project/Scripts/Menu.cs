using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public Canvas m_Menu;
    public Canvas m_SpaceBar;
    public KeyCode m_Keyboard;

    public void Resume()
    {
        TimePaused();
    }

    public void QuitApplication()
    {
        Application.Quit();
    }

    void Update()
    {
        if (m_SpaceBar.gameObject.activeSelf && Input.GetKeyDown(m_Keyboard))
        {
            m_Menu.gameObject.SetActive(!m_Menu.gameObject.activeSelf);
            TimePaused();
        }
	}

    void TimePaused()
    {
        Time.timeScale = (Time.timeScale == 1) ? 0 : 1;
    }
}
