using System.Collections;
using System.Collections.Generic;
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
        Vector3 placePos = Camera.main
            .ScreenToWorldPoint(Input.mousePosition);
        
        placePos.z = tower_zAxis;
        placePos.x = Mathf.RoundToInt(placePos.x);
        placePos.y = Mathf.RoundToInt(placePos.y);
        if(Input.GetKeyUp(KeyCode.Mouse0))
        {
            Instantiate(tower, placePos, Quaternion.identity);
        }
    }
}
