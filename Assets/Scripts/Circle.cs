using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    #region Singleton class: Circle
    public static Circle Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    #endregion
    [SerializeField] ParticleSystem winFX;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Circle y ekseninde harket eder.
        transform.position = new Vector3(transform.position.x, transform.position.y + (speed * Time.deltaTime), transform.position.z);

    }

    private void OnTriggerEnter(Collider other)
    {
        //Circle bitiþ çizgisine geldiðinde++
        string tag = other.tag;
        if (tag.Equals("Finish"))
        {
            //++ particle system çalýþýr.
            winFX.Play();
            //Debug.Log("Finish");
            //++ hýz sýfýrlanýr.
            speed = 0;
            //++ winPanel gözükür
            UIManager.Instance.ShowWinPanel();
        }
        
        
    }
}
