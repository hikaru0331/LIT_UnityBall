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
        //�J�����̍��W��player�̍��W��additionalPosition�̍��W�����Z�������W�ɕύX����
        this.transform.position = Vector3.Lerp(this.transform.position, player.transform.position + offset, 3.0f * Time.deltaTime); 
    }
}
