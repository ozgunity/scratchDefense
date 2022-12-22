using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private GameObject darkBlue;
    [SerializeField]
    private GameObject lightBlue;

    private Vector3 pos;

    private void Awake()
    {
        DrawLevel();
    }
    void DrawLevel()
    {
        for(int k=0; k<10; k++)
        {
            for (int i = 0; i < 23; i++)
            {
                if(i % 2 == 0 && k % 2 == 0)
                {
                    pos = new Vector3(i - 11, k - 4.5f, 0);
                    var tile = Instantiate(darkBlue, pos, Quaternion.identity);
                    tile.transform.parent = gameObject.transform;
                    tile.name = (i - 11 + " , " + (k - 4.5f));
                }
                else if(i % 2 != 0 && k % 2 != 0)
                {
                    pos = new Vector3(i - 11, k - 4.5f, 0);
                    var tile = Instantiate(darkBlue, pos, Quaternion.identity);
                    tile.transform.parent = gameObject.transform;
                    tile.name = (i - 11 + " , " + (k - 4.5f));
                }

                else
                {
                    pos = new Vector3(i - 11, k - 4.5f, 0);
                    var tile = Instantiate(lightBlue, pos, Quaternion.identity);
                    tile.transform.parent = gameObject.transform;
                    tile.name = (i - 11 + " , " + (k - 4.5f));
                }
            }
        }
        
    }


    


}
            
      


            
        

