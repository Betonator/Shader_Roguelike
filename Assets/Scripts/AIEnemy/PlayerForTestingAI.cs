using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerForTestingAI : MonoBehaviour
{
    private Rigidbody m_playerBody;
    [SerializeField]
    float m_playerSpeed= 2f;
    void Start()
    {
        m_playerBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
            MoveUp();
        }
        if (Input.GetKey(KeyCode.A)){
            MoveLeft();
        }
        if (Input.GetKey(KeyCode.S)){
            MoveDown();
        }
        if (Input.GetKey(KeyCode.D)){
            MoveRight();
        }
    }

    void MoveDown(){
        m_playerBody.AddForce(Vector3.right*m_playerSpeed);
    }

    void MoveUp(){
        m_playerBody.AddForce(Vector3.left*m_playerSpeed);
    }

    void MoveRight(){
        m_playerBody.AddForce(Vector3.forward*m_playerSpeed);
    }

    void MoveLeft(){
        m_playerBody.AddForce(Vector3.back*m_playerSpeed);
    }
}
