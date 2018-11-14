using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridObject : MonoBehaviour
{
    [SerializeField] private GameObject m_Selected;

    [SerializeField] private Sprite[] m_StateSprite;

    private SpriteRenderer m_SR;

	void Start ()
    {
        m_Selected = transform.GetChild(0).gameObject;
        m_SR = m_Selected.GetComponent<SpriteRenderer>();
    }
	
	void Update ()
    {
		
	}

    public void SetState(int state)
    {
        m_SR.sprite = m_StateSprite[state];
    }
}
