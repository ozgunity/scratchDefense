using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Tilemaps;

[ExecuteAlways]
public class TilemapPainter : MonoBehaviour
{
    public Tile darkBLue;
    public Tile lightBLue;

    public Tilemap tilemap;

    public Vector3Int enemySpawnPoint;
    public Vector3Int finishLine;

    
    void Awake()
    {
        PaintTiles();
    }
    void Start()
    {
        
    }

    void PaintTiles()
    {
        for (int k = 0; k <= 9; k++)
        {
            for (int i = 0; i <= 19; i++)
            {
                Vector3Int paintThis = new Vector3Int(i - 10, k - 5, 0);
                if (i % 2 == 0 && k % 2 == 0)
                {
                    tilemap.SetTile(paintThis, darkBLue);
                }
                else if (i % 2 != 0 && k % 2 != 0)
                {
                    tilemap.SetTile(paintThis, darkBLue);
                }
                else
                {
                    tilemap.SetTile(paintThis, lightBLue);

                }
            }
        }
    }


}
