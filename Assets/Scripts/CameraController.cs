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
        //�J�����̍��W��player�̍��W��additionalPosition�̍��W�����Z�������W�ɕύX����
        this.transform.position = player.transform.position + additionalPosittion;
    }
}
