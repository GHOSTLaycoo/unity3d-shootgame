using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskTrigger : MonoBehaviour {

    private GameObject[] m_Desk;
	void Start () {
        m_Desk = GameObject.FindGameObjectsWithTag("Desks");

        for(int i=0;i<m_Desk.Length;i++)
        {
            Debug.Log(m_Desk[i].name);
        }

    }
	
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Z))
        {
            DesksUp();
        }

        if(Input.GetKeyUp(KeyCode.Z))
        {
            DesksDown();
        }
	}
    void DesksUp()
    {
        for(int i=0;i<m_Desk.Length;i++)
        {
            m_Desk[i].GetComponent<Transform>().Translate(Vector3.up * 2, Space.Self);
        }
    }
    void DesksDown()
    {
        for (int i = 0; i < m_Desk.Length; i++)
        {
            m_Desk[i].GetComponent<Transform>().Translate(Vector3.up * -2, Space.Self);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
         if(other.gameObject.name=="Student")
        {
            DesksUp();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Student")
        {
            DesksDown();
        }
    }

}
