using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways]
public class LevelManager : MonoBehaviour
{
    TextMeshPro myText;
    Vector2Int vec = new Vector2Int();

    void Awake()
    {
        myText = GetComponent<TextMeshPro>();
    }

    void Update()
    {
        if(!Application.isPlaying)
        {
            Coordinates();
            UpdateName();
        }
        else
        {
            myText.enabled = false;
            
        }
    }

    void Coordinates()
    {
        vec.x = Mathf.RoundToInt(transform.position.x);
        vec.y = Mathf.RoundToInt(transform.position.y);

        myText.text = vec.x + "," + vec.y;
    }

    void UpdateName()
    {
        transform.parent.name = vec.ToString();
    }

    //void DrawLevel()
    //{
    //    for(int k=0; k<12; k++)
    //    {
    //        for (int i = 0; i < 23; i++)
    //        {
    //            if(i % 2 == 0 && k % 2 == 0)
    //            {
    //                pos = new Vector3(i - 11, k - 5, 0);
    //                var tile = Instantiate(darkBlue, pos, Quaternion.identity);
    //                tile.transform.parent = gameObject.transform;
    //                tile.name = (i - 11 + " , " + (k - 5));
    //            }
    //            else if(i % 2 != 0 && k % 2 != 0)
    //            {
    //                pos = new Vector3(i - 11, k - 5, 0);
    //                var tile = Instantiate(darkBlue, pos, Quaternion.identity);
    //                tile.transform.parent = gameObject.transform;
    //                tile.name = (i - 11 + " , " + (k - 5));
    //            }

    //            else
    //            {
    //                pos = new Vector3(i - 11, k - 5, 0);
    //                var tile = Instantiate(lightBlue, pos, Quaternion.identity);
    //                tile.transform.parent = gameObject.transform;
    //                tile.name = (i - 11 + " , " + (k - 5f));
    //            }
    //        }
    //    }

    //}




}
            
      


            
        

