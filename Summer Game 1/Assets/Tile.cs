using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

    [SerializeField]
    private int m_index;

    public bool m_isBomb { get; set; }


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
