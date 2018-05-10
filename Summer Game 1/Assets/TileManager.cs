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


    }
	
	// Update is called once per frame
	void Update ()
    {
        
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
