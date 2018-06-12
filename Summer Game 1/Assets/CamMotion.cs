using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMotion : MonoBehaviour {

    public float m_screenBuffer;

    [SerializeField]
    private float m_speed;
    private Vector3 m_newPos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.mousePosition.x < m_screenBuffer )
        {
            this.transform.position = this.transform.position + new Vector3(-Time.deltaTime * m_speed, 0, 0);
        }
        if (Input.mousePosition.x > Screen.width - m_screenBuffer)
        {
            this.transform.position = this.transform.position + new Vector3(Time.deltaTime * m_speed, 0, 0);
        }
        if (Input.mousePosition.y < m_screenBuffer)
        {
            this.transform.position = this.transform.position + new Vector3( 0, -Time.deltaTime * m_speed, 0);
        }
        if (Input.mousePosition.y > Screen.height - m_screenBuffer)
        {
            this.transform.position = this.transform.position + new Vector3(0, Time.deltaTime * m_speed, 0);
        }
    }
}
