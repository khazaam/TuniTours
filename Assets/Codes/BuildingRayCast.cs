using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingRayCast : MonoBehaviour
{
    public Transform camera;

    Transform prevBuilding = null;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position + camera.forward * 5, camera.forward, 
            out hit, Mathf.Infinity))
        {
            Transform currentBuilding = hit.collider.gameObject.transform;
            if (hit.collider.gameObject.transform.tag == "Interactable")
            {
                if (prevBuilding == null)
                {
                    for(int i=0; i< currentBuilding.childCount; i++)
                        currentBuilding.GetChild(i).GetChild(0).gameObject.active = true;
                    prevBuilding = currentBuilding;
                }
                else if (prevBuilding != currentBuilding)
                {
                    for (int i = 0; i < prevBuilding.childCount; i++)
                        prevBuilding.GetChild(i).GetChild(0).gameObject.active = false;
                    for (int i = 0; i < currentBuilding.childCount; i++)
                        currentBuilding.GetChild(i).GetChild(0).gameObject.active = true;
                    prevBuilding = currentBuilding;
                }
                else
                {
                    for (int i = 0; i < currentBuilding.childCount; i++)
                    {
                        Vector3 lookDirection = currentBuilding.GetChild(i).GetChild(0).position - transform.position;
                        lookDirection = new Vector3(lookDirection.x, 0, lookDirection.z);
                        currentBuilding.GetChild(i).GetChild(0).forward = lookDirection;
                    }
                }
            }
        }
                
    }
}
