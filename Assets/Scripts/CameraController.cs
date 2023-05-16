using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Vector3 additionalPosittion;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = this.transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //カメラの座標をplayerの座標へadditionalPositionの座標を加算した座標に変更する
        this.transform.position = Vector3.Lerp(this.transform.position, player.transform.position + offset, 3.0f * Time.deltaTime); 
    }
}
