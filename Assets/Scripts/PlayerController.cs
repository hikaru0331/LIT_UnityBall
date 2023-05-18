using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject restartPosition;

    public Text objectName;

    // Start is called before the first frame update
    void Start()
    {
        objectName.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        //Debug.Log(other.gameObject.name);

        objectName.gameObject.SetActive(true);
        objectName.text = other.gameObject.name;

        Invoke("DeleteText", 1.0f);

    }

    public void DeleteText()
    {
        objectName.gameObject.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if( other.gameObject.name == "Goal")
        {
            this.transform.position = restartPosition.transform.position;
        }
    }
}
