using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looker : MonoBehaviour
{
    public GameObject m_enemy;
    private float m_reset = 5;
    private bool m_ifMovingDown;
    private float m_movingDown = 0.1f;

    void Update()
    {
        if(m_ifMovingDown == false){
            transform.position -= new Vector3(0,0,0.1f);
        } else {
            transform.position += new Vector3(0,0,0.1f);
        }
        if (transform.position.z >  10)
        {
            m_ifMovingDown = false ;
        } else if (transform.position.z < -10){
            m_ifMovingDown = true;
        }
        m_reset -= Time.deltaTime;
        if (m_reset < 0)
        {
            m_enemy.GetComponent<Enemy>().enabled = false;
            GetComponent<SphereCollider>().enabled  = true;
        }
    }

    private void OnTriggerEnter(Collider collision){
        if (collision.gameObject.tag == "Player"){
            m_enemy.GetComponent<Enemy>().enabled =  true;
            m_reset = 5;
            GetComponent<SphereCollider>().enabled = false;
        }
    }
}
