using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Rigidbody m_Rigidbody;
    float speed = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        //m_Rigidbody = GetComponent<Rigidbody>();
        speed = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))     //forwards
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            //m_Rigidbody.AddForce(Time.deltaTime * 0, 0, 3);
        }
        if (Input.GetKey(KeyCode.S))    //backwards
        { 
            transform.Translate(-1 * Vector3.forward * Time.deltaTime * speed);
            //m_Rigidbody.AddForce(Time.deltaTime * 0, 0, -3);
        }
        if (Input.GetKey(KeyCode.A))   //left
        {  
            transform.Translate(-1 * Vector3.right * Time.deltaTime * speed);
            //m_Rigidbody.AddForce(Time.deltaTime * -300, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))   //right
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            //m_Rigidbody.AddForce(Time.deltaTime * 300, 0, 0);
        }
            
        
    }
}

