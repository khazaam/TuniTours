using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Teleport : MonoBehaviour
{
    public GameObject teleportLists;
    public Transform player;
    [HideInInspector]
    public Transform currentTeleport;
    [HideInInspector]
    public bool isEntered = false;

    Dictionary<Transform, Transform> buttonTeleport = new Dictionary<Transform, Transform>();

    void Start()
    {
        teleportLists.transform.parent.gameObject.SetActive(false);
        for (int i = 0; i < teleportLists.transform.childCount; i++)
        {
            teleportLists.transform.GetChild(i).GetChild(0).GetComponent<Text>().text = transform.GetChild(i).name;
            buttonTeleport.Add(transform.GetChild(i), teleportLists.transform.GetChild(i));
            buttonTeleport[transform.GetChild(i)].GetComponent<Button>().onClick.AddListener(Teleportation);
        }
    }

    void Update()
    {
        if (currentTeleport != null)
        {
            if (isEntered)
            {
                if (ViewController.isNormalView == ViewController.Views.Wait)
                {
                    for (int i = 0; i < transform.childCount; i++)
                    {
                        if (currentTeleport.name == transform.GetChild(i).name)
                        {
                            ChangeNormalColor(Color.green, buttonTeleport[transform.GetChild(i)].GetComponent<Button>());
                        }
                        else
                        {
                            ChangeNormalColor(Color.white, buttonTeleport[transform.GetChild(i)].GetComponent<Button>());
                        }
                    }
                    teleportLists.transform.parent.gameObject.SetActive(true);
                }
            }
            else
            {
                for (int i = 0; i < transform.childCount; i++)
                {
                    if (currentTeleport.name == transform.GetChild(i).name)
                    {
                        ChangeNormalColor(Color.white, buttonTeleport[transform.GetChild(i)].GetComponent<Button>());
                    }
                }
                teleportLists.transform.parent.gameObject.SetActive(false);
            }
        }
    }

    void ChangeNormalColor(Color color, Button button)
    {
        ColorBlock colorBlock = button.colors;
        colorBlock.normalColor = color;
        button.colors = colorBlock;
    }

    void Teleportation()
    {
        var selectedButton = EventSystem.current.currentSelectedGameObject;
        if (selectedButton != null)
        {
            foreach (KeyValuePair<Transform, Transform> item in buttonTeleport)
            {
                if(item.Value == selectedButton.transform)
                {
                    Vector3 position = new Vector3(item.Key.position.x, player.transform.position.y, item.Key.position.z);
                    player.transform.position = position;
                    currentTeleport = item.Key;
                }
            }
        }
    }
}
