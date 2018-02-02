using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class AnimationsScenes : MonoBehaviour {

    public GameObject m_RobotNeck;
    public GameObject m_RobotEyes;
    public AudioSource m_SoundSuspence;
    public Image m_BlackScreen;

    private void Awake()
    {
        m_neck = m_RobotNeck.GetComponent<Animator>();
    }

    void Update () {
        if (!m_neck.GetBool("ActiveRobotHead") && !m_SoundSuspence.isPlaying && Input.GetKeyDown(KeyCode.Space))
            StartCoroutine("MoveRobotHead");
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
