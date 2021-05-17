using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class ReplaceTiles : MonoBehaviour
{

    TilemapRenderer renderer;
    Tilemap map;

    public GameObject Wall;

    // Start is called before the first frame update
    void Start()
    {
        map = gameObject.GetComponent<Tilemap>();
        //GameObject Wall = GameObject.FindGameObjectWithTag("wallTemp");
        Vector3 tilePosition;
        Vector3Int coordinate = new Vector3Int(0, 0, 0);
        foreach (var position in map.cellBounds.allPositionsWithin)
        {
            if (map.HasTile(position)) {
                GameObject.Instantiate(Wall, new Vector3(position.x,position.y,0), new Quaternion());
            }
        }
        gameObject.GetComponent<TilemapRenderer>().enabled = false;
        gameObject.GetComponent<TilemapCollider2D>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
