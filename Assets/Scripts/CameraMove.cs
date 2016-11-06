using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CameraMove : MonoBehaviour {

    private GameObject player;
    private Vector3 offset;
    

    void Start()
    {
        player = GameObject.Find("Player");
        offset = transform.position - player.transform.position;       
    }

    void LateUpdate () {
        if (player != null)
        {
            transform.position = new Vector3((player.transform.position.x + offset.x), 0, -10);
        }
	}
}
