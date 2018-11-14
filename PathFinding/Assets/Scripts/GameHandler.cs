using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    [SerializeField] private GameObject m_SelectedGameObject;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Selected_GridObject(GameObject newObject)
    {
        if (m_SelectedGameObject != null)
        {
            if (m_SelectedGameObject != newObject)
            {
                m_SelectedGameObject.GetComponent<GridObject>().SetState(0);
                m_SelectedGameObject = newObject;
                m_SelectedGameObject.GetComponent<GridObject>().SetState(1);
            }
            else
            {
                m_SelectedGameObject.GetComponent<GridObject>().SetState(0);
                m_SelectedGameObject = null;
            }
        }
        else
        {
            m_SelectedGameObject = newObject;
            m_SelectedGameObject.GetComponent<GridObject>().SetState(1);
        }
    }
}
