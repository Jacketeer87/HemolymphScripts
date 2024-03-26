using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{

    [SerializeField] PlayerBug bug;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 input = Vector3.zero;

        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) ){
            transform.Rotate(Vector3.up * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            transform.Rotate(-Vector3.up * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) ){
            input.y = 1;
        }

        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){
            input.y = -1;
        }


        bug.moveBug(input);
    
    }
}
