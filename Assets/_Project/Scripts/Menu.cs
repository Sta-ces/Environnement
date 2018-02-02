using UnityEngine;

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

    private void Update()
    {
        if (m_SpaceBar.gameObject.activeSelf && Input.GetKeyDown(m_Keyboard))
        {
            m_Menu.gameObject.SetActive(!m_Menu.gameObject.activeSelf);
            TimePaused();
        }
	}

    private void TimePaused()
    {
        Time.timeScale = (Time.timeScale == 1) ? 0 : 1;
    }
}
