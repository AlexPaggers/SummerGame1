using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour {

    const float m_tileSpriteSize = 1.0f;

    //public Tile[] m_tiles;
    public List<GameObject> m_tiles;
    public int m_size = 16;

    public GameObject m_emptyTile;

    private int m_width, m_height;

	// Use this for initialization
	void Start ()
    {
        createMap();

        Mathf.Floor(Mathf.Sqrt(m_size));
    }
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    void createMap()
    {
        for(int i = 0; i < m_size; i++)
        {
            GameObject _tile = (GameObject)Instantiate(m_emptyTile);
            m_tiles.Add(_tile);
            _tile.transform.position += new Vector3 ((m_tileSpriteSize * i) * 2/3,
                                                    m_tileSpriteSize / ((i % 2)+1),
                                                     0);
            Debug.Log(i % 2);
        }
    }
}
