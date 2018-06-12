using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour {

    const float m_tileSpriteSize = 1.0f;

    //public Tile[] m_tiles;
    public List<GameObject> m_tiles;
    public int m_size;

    public GameObject m_emptyTile;

    private float m_width;

	// Use this for initialization
	void Start ()
    {
        createMap();

        for (int i = 0; i < m_tiles.Count; i++)
        {
            m_tiles[i].GetComponent<Tile>().m_isBomb = true;
        }

        for (int i = 0; i < m_tiles.Count; i++)
        {
            ClickTile(i);
        }

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
            if (hit)
            {
                //hit.collider.GetComponentInParent<Tile>().m_index
            }
        }

    }

    void ClickTile(int _index)
    {
        //needs to know which ways to check, going clockwise starting up
        //bool[] directions = new bool[] { false, false, false, false, false, false } ;
        
        if(_index > m_size)
        {
            //can check down
            if(m_tiles[_index - m_size].GetComponent<Tile>().m_isBomb)
            {
                m_tiles[_index].GetComponent<Tile>().m_surroundingBombs++;
            }

            if (_index % m_size == 0)
            {
                //check right
                if (m_tiles[_index - m_size + 1].GetComponent<Tile>().m_isBomb)
                {
                    m_tiles[_index].GetComponent<Tile>().m_surroundingBombs++;
                }

            }

            if (_index % m_size == m_size - 1)
            {
                //check left
                if (m_tiles[_index - m_size - 1].GetComponent<Tile>().m_isBomb)
                {
                    m_tiles[_index].GetComponent<Tile>().m_surroundingBombs++;
                }
            }

        }

        if(_index < m_tiles.Count - m_size)
        {
            //can check up

            if (m_tiles[_index + m_size].GetComponent<Tile>().m_isBomb)
            {
                m_tiles[_index].GetComponent<Tile>().m_surroundingBombs++;
            }

            if (_index % m_size == 0)
            {
                //check right
                if (m_tiles[_index + m_size + 1].GetComponent<Tile>().m_isBomb)
                {
                    m_tiles[_index].GetComponent<Tile>().m_surroundingBombs++;
                }

            }

            if (_index % m_size == m_size - 1)
            {
                //check left
                if (m_tiles[_index + m_size - 1].GetComponent<Tile>().m_isBomb)
                {
                    m_tiles[_index].GetComponent<Tile>().m_surroundingBombs++;
                }
            }

        }


    }

    void createMap()
    {
        for(int j = 0; j < m_size; j++)
        {
            for (int i = 0; i < m_size; i++)
            {
                GameObject _tile = (GameObject)Instantiate(m_emptyTile);

                _tile.GetComponent<Tile>().createTile(m_tiles.Count);

                m_tiles.Add(_tile);

                _tile.transform.position += new Vector3((m_tileSpriteSize * i) * (m_tileSpriteSize * 0.75f),
                                                        m_tileSpriteSize / ((i % 2) + 1) + (j),
                                                         0);
            }
        }
    }
}
