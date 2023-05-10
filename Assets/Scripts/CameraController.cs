using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Vector3 additionalPosittion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //カメラの座標をplayerの座標へadditionalPositionの座標を加算した座標に変更する
        this.transform.position = player.transform.position + additionalPosittion;
    }
}
