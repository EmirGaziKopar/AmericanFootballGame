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
    private void FixedUpdate()
    {
        moveTheJack();
    }
    void moveTheJack()
    {
        anim.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        anim.SetFloat("Vertical", Input.GetAxis("Vertical"));

        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(new Vector3(0f, 0f, Input.GetAxis("Vertical")) * velocity * 2f);
            }
            else if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(new Vector3(0f, 0f, Input.GetAxis("Vertical")) * velocity * 2f);
            }

            

            if (Input.GetKeyDown(KeyCode.Space))
            {
                rigidbody.AddForce(transform.up * jumpPower);
            }






        }
        else
        {
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(new Vector3(0f, 0f, Input.GetAxis("Vertical")) * velocity);
            }
            else if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(new Vector3(0f, 0f, Input.GetAxis("Vertical")) * velocity);
            }

            

            if (Input.GetKeyDown(KeyCode.Space))
            {
                rigidbody.AddForce(transform.up * jumpPower);
            }
        }
    }
        
}