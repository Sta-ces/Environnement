using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationsScenes : MonoBehaviour {

    public GameObject m_RobotNeck;

    private void Awake()
    {
        m_neck = m_RobotNeck.GetComponent<Animator>();
    }

    void Update () {
        if (!m_neck.GetBool("ActiveRobotHead") && Input.GetKeyDown(KeyCode.Space))
            MoveRobotHead();
	}

    void MoveRobotHead()
    {
        m_neck.SetBool("ActiveRobotHead",true);
    }

    private Animator m_neck;
}
