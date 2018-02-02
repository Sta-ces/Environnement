using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationsScenes : MonoBehaviour {

    public GameObject m_RobotNeck;
    public GameObject m_RobotEyes;
    public AudioSource m_SoundSuspence;
    public Canvas m_BlackScreen;
    public Canvas m_TextSpaceBar;
    public Animator m_AnimationSpotLight;
    public Animator m_AnimationCamera;
    [Range(1,20)]
    public int m_SecondsWaitingSpotLight = 5;
    public KeyCode m_Keyboard;

    private void Awake()
    {
        m_neck = m_RobotNeck.GetComponent<Animator>();
    }

    private IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(m_SecondsWaitingSpotLight);
            m_AnimationSpotLight.SetTrigger("ActiveSpotLight");
        }
    }

    void Update () {
        if (m_TextSpaceBar.gameObject.activeSelf && Input.GetKeyDown(m_Keyboard))
        {
            m_TextSpaceBar.gameObject.SetActive(false);
            m_AnimationCamera.SetTrigger("AnimCamera");
            StartCoroutine("MoveRobotHead");
        }

        if (m_BlackScreen.gameObject.activeSelf && Input.GetKeyDown(m_Keyboard))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    IEnumerator MoveRobotHead()
    {
        m_SoundSuspence.Play();
        yield return new WaitForSeconds(m_SoundSuspence.clip.length - 1);
        m_neck.SetBool("ActiveRobotHead",true);
        m_RobotEyes.SetActive(true);
        StartCoroutine("DisplayBlackScreen");
    }

    IEnumerator DisplayBlackScreen()
    {
        yield return new WaitForSeconds(0.5f);
        m_BlackScreen.gameObject.SetActive(true);
    }

    private Animator m_neck;
}
