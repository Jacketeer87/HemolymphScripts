using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBug : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] float speed = 0f;
    [SerializeField] float health = 0f;

    [Header("Physics")]
    //[SerializeField] layerMask wallMask;
    //[SerializeField] layerMask floorMask;
    //[SerializeField] layerMask element;

    [Header("Flavor")]
    [SerializeField] string bugType = "n/a";

    [Header("Tracked Data")]
    [SerializeField] Vector3 start = Vector3.zero;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveBug(Vector3 direction){
        rb.velocity = direction*speed;
    }
}
