using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    public GameObject player;
    public float accelerometerSensitivity = 1.0f;

    void Start()
    {
        Debug.Log(PlayerPrefs.GetString("name"));
        if (player == null)
        {
            player = this.gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 touchPosition = Camera.main
                    .ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
            player.transform.position = touchPosition;
        }
    }
}
