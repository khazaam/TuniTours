using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewController : MonoBehaviour
{
    public enum Views
    {
        GoUp,
        GoDown,
        Wait
    }

    public static Views isNormalView;

    public Transform camera;
    public Transform player;
    public Transform teleportList;
    public Transform finalCameraLocation;
    public Transform buildingNames;
    public float cameraSpeed;

    private Vector3 firstCameraPosition;
    private Quaternion firstCameraRotation;
    private int timesEpressed = 0;
    private bool isTeleportListActive;


    void Start()
    {
        firstCameraPosition = camera.position;
        firstCameraRotation = camera.rotation;
        isNormalView = Views.Wait;
        EnableFog();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if(timesEpressed == 0)
            {
                isNormalView = Views.GoUp;
                camera.GetComponent<MouseLook>().enabled = false;
                player.GetComponent<PlayerMovement>().enabled = false;
                isTeleportListActive = teleportList.parent.gameObject.active;
                teleportList.parent.gameObject.SetActive(false);
                firstCameraPosition = camera.position;
                firstCameraRotation = camera.rotation;
            }
            else
            {
                isNormalView = Views.GoDown;
            }
            timesEpressed = (timesEpressed + 1) % 2;
        }

        if (isNormalView == Views.GoUp)
        {
            DisableFog();
            if (Vector3.Distance(camera.position, finalCameraLocation.position) >= 1.0f)
            {

                camera.position = Vector3.Slerp(camera.position, finalCameraLocation.position, cameraSpeed * Time.deltaTime);
                camera.rotation = Quaternion.Slerp(camera.rotation, finalCameraLocation.rotation, cameraSpeed * Time.deltaTime);
            }
            else
            {
                buildingNames.gameObject.SetActive(true);
            }
        }
        else if (isNormalView == Views.GoDown)
        {
            buildingNames.gameObject.SetActive(false);
            camera.position = Vector3.Slerp(camera.position, firstCameraPosition, cameraSpeed * Time.deltaTime);
            camera.rotation = Quaternion.Slerp(camera.rotation, firstCameraRotation, cameraSpeed * Time.deltaTime);
            if (Vector3.Distance(camera.position, firstCameraPosition) < 0.01f)
            {
                isNormalView = Views.Wait;
            }
        }
        else
        {
            camera.GetComponent<MouseLook>().enabled = true;
            player.GetComponent<PlayerMovement>().enabled = true;
            teleportList.parent.gameObject.SetActive(isTeleportListActive);
        }
    }

    void EnableFog()
    {
        RenderSettings.fog = true;
    }

    void DisableFog()
    {
        RenderSettings.fog = false;
    }
}
