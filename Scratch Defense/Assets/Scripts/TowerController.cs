using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class TowerController : MonoBehaviour
{
    [SerializeField]
    private GameObject tower;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        PlaceMachineGun();
    }

    public void PlaceMachineGun()
    {
        const int tower_zAxis = 0;
        
        if(Input.GetKeyUp(KeyCode.Mouse0))
        {
            Vector3 placePos = Camera.main
            .ScreenToWorldPoint(Input.mousePosition);

            placePos.z = tower_zAxis;
            placePos.x = Mathf.RoundToInt(placePos.x);
            placePos.y = Mathf.RoundToInt(placePos.y);

            Instantiate(tower, placePos, Quaternion.identity);
            TagChanger(placePos);
        }
    }

    void TagChanger(Vector3 myVec)
    {
        Component[] pathTransforms;
        pathTransforms = GetComponentsInChildren(typeof(Transform));
        
        foreach (Transform transform in pathTransforms)
        {
            if (transform.position == myVec)
            {               
                transform.tag = "TowerPlaced";
            }
        }
    }
}
