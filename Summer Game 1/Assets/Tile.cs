using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

    [SerializeField]
    public int m_index;

    public bool m_isBomb;

    public int m_surroundingBombs;


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void checkSurrounding()
    {
       
    }

    public void createTile(int _index)
    {
        m_index = _index;
        GetComponentInChildren<TextMesh>().text = m_index.ToString();
        this.gameObject.name = _index.ToString();
    }

    public bool clicked()
    {
        if(m_isBomb)
        {
            return m_isBomb;
        }
        else
        {
            return m_isBomb;
        }
    }


}
