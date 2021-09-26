using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    new Rigidbody rigidbody;
    [SerializeField] float jumpPower;
    Animator anim;
    [SerializeField] float velocity;


    private void Awake()
    {
        anim = this.gameObject.GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {     
        moveTheJack();
    }
    void moveTheJack()
    {
        if(transform.position.z >= 560.3f && transform.position.z <= 576f)
        {
            anim.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
            anim.SetFloat("Vertical", Input.GetAxis("Vertical"));
            Debug.Log("konum: " + transform.position.z);

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(new Vector3(0f, 0f, Input.GetAxis("Vertical")) * velocity * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(new Vector3(0f, 0f, Input.GetAxis("Vertical")) * velocity * Time.deltaTime);
            }



            if (Input.GetKeyDown(KeyCode.Space))
            {
                rigidbody.AddForce(transform.up * jumpPower);
            }
        }
        else if(transform.position.z < 560.3f)
        {
            transform.position += new Vector3(0f, 0f, 1f*Time.deltaTime);
        }
        else if (transform.position.z > 576f)
        {
            transform.position += new Vector3(0f, 0f, -1f*Time.deltaTime );
        }

    }
        
}