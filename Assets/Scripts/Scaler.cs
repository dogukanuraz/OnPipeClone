using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] GameObject circle;

    Vector3 scale = new Vector3(-0.1f, -0.1f, 0f);
    float minScale = 0.3f;
    float midScale = 0.6f;
    float maxScale = 0.9f;
    float normalScale = 1.2f;
    string objectTag;


    private void Start()
    {
    }

    private void OnTriggerStay(Collider other)
    {
        objectTag = other.tag;
        Debug.Log(objectTag);
    }
    

    void Update()
    {
        //Silindirlerin boyutuna göre Circle'ýn boyutu deðiþir.
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (objectTag== "Min" || objectTag == "Cube" || objectTag == "Obstacle")
            {
                if (circle.transform.localScale.x > minScale || circle.transform.localScale.y > minScale)
                {
                    circle.transform.localScale += scale;
                }
            }
            if (objectTag == "Mid" || objectTag == "MidCube")
            {
                if (circle.transform.localScale.x > midScale)
                {
                    circle.transform.localScale += scale;
                }
            }
            if (objectTag == "Max" || objectTag == "MaxCube")
            {
                if (circle.transform.localScale.x > maxScale)
                {
                    circle.transform.localScale += scale;
                }
            }
        }
        else
        {
            //Týklanmadýðý durumda Circle eski boyutuna döner.
            if (circle.transform.localScale.x < normalScale)
            {
                circle.transform.localScale -= scale;
            }
        }

        
    }

    


}
