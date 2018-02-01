using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayAndNight : MonoBehaviour {

    public Light m_Sun;
    [Range(0,10)]
    public int m_Seconds = 1;
    
	
	void FixedUpdate () {
        m_Sun.transform.rotation = Quaternion.Euler(new Vector3(m_Sun.transform.rotation.x + Time.realtimeSinceStartup, 0f, 0f));
	}
}
