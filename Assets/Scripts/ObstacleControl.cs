using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleControl : MonoBehaviour
{
    #region Singleton class: ObstacleControl
    public static ObstacleControl Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    #endregion


    private void OnTriggerEnter(Collider other)
    {
        //Circle engel iyi tetiklendiðinde losePanel gösterilir.
        string tag = other.tag;
        if (tag.Equals("Obstacle"))
        {
            Circle.Instance.speed = 0;
            UIManager.Instance.ShowLosePanel();
            
            Debug.Log("Restart");
        }



        if (tag == "Cube" || tag == "MidCube" || tag == "MaxCube")
        {
            //Circle küpler ile tetiklendiðinde score artar.
            UIManager.Instance.score++;
            //Küplere güç uygulanarak ekrandan düþmeleri saðlanýr.
            Vector3 force = new Vector3(0f, 0f, -10f);
            Rigidbody rigidbody = other.GetComponent<Rigidbody>();
            rigidbody.AddForceAtPosition(force, other.transform.position, ForceMode.Impulse);
            rigidbody.useGravity = true;

        }
    }
}
