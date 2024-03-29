using System;
using System.Collections.Generic;
using UnityEngine;


public class BallMovement : MonoBehaviour
{
    // [SerializeField] MovementPlat movementPlat;
    private int Platform = 1;
    [SerializeField] private GameObject plat1;
    [SerializeField] private GameObject plat2;
    [SerializeField] private GameObject plat3;
    [SerializeField] private GameObject plat4;

    // [SerializeField] private List<GameObject> gameobjectlist = new List<GameObject>();

    // private void Start()
    // {
    //     foreach (GameObject g in gameobjectlist)
    //     {
    //         Debug.Log(g.name);
    //     }
    // }
    void Update()
    {
        if (Platform == 1)
        {
            transform.position = new Vector3(plat1.transform.position.x, plat1.transform.position.y + 1f, plat1.transform.position.z);
        }
        if (Platform == 2)
        {
            transform.position = new Vector3(plat2.transform.position.x, plat2.transform.position.y + 1f, plat2.transform.position.z);
        }
        if (Platform == 3)
        {
            transform.position = new Vector3(plat3.transform.position.x, plat3.transform.position.y + 1f, plat3.transform.position.z);
        }
        if (Platform == 4)
        {
            transform.position = new Vector3(plat4.transform.position.x, plat4.transform.position.y + 1f, plat4.transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (plat1.transform.position.y - plat2.transform.position.y < 0.5f && plat1.transform.position.y - plat2.transform.position.y > -0.5f)
            {
                if (Platform == 1)
                {
                    transform.position = plat2.transform.position + new Vector3(0f, 1f, 0f);
                    Platform = 2;
                    Debug.Log("Transferred From 1 to 2");
                }
                else if (Platform == 2)
                {
                    transform.position = plat1.transform.position + new Vector3(0f, 1f, 0f);
                    Platform = 1;
                    Debug.Log("Transferred From 2 to 1");
                }

            }
            if (plat2.transform.position.y - plat3.transform.position.y < 0.5f && plat2.transform.position.y - plat3.transform.position.y > -0.5f)
            {
                if (Platform == 2)
                {
                    transform.position = plat3.transform.position + new Vector3(0f, 1f, 0f);
                    Platform = 3;
                    Debug.Log("Transferred From 2 to 3");
                }
                else if (Platform == 3)
                {
                    transform.position = plat2.transform.position + new Vector3(0f, 1f, 0f);
                    Platform = 2;
                    Debug.Log("Transferred From 3 to 2");
                }

            }
            if (plat3.transform.position.y - plat4.transform.position.y < 0.5f && plat3.transform.position.y - plat4.transform.position.y > -0.5f)
            {
                if (Platform == 3)
                {
                    transform.position = plat4.transform.position + new Vector3(0f, 1f, 0f);
                    Platform = 4;
                    Debug.Log("Transferred From 3 to 4");
                }
                else if (Platform == 4)
                {
                    transform.position = plat3.transform.position + new Vector3(0f, 1f, 0f);
                    Platform = 3;
                    Debug.Log("Transferred From 4 to 3");
                }
            }
        }
    }
}
