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

                if (Input.GetKey(KeyCode.D))
                {
                    transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * velocity* 2f);
                }

                else if (Input.GetKey(KeyCode.A))
                {
                    transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * velocity* 2f);
                }
                else
                {
                    transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * velocity * 2f);
                }
            }
            else if (Input.GetKey(KeyCode.W))
            {

                if (Input.GetKey(KeyCode.A))
                {
                    Debug.Log("was");
                    transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * velocity * 2f);
                }

                else if (Input.GetKey(KeyCode.D))
                {
                    Debug.Log("was");
                    transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * velocity * 2f);
                }
                else
                {
                    transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * velocity * 2f);
                }
            }

            else if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * velocity * 2f);
            }

            else if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * velocity * 2f);
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

                if (Input.GetKey(KeyCode.D))
                {
                    transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * velocity);
                }

                else if (Input.GetKey(KeyCode.A))
                {
                    transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * velocity);
                }
                else
                {
                    transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * velocity);
                }
            }
            else if (Input.GetKey(KeyCode.W))
            {

                if (Input.GetKey(KeyCode.A))
                {
                    Debug.Log("was");
                    transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * velocity);
                }

                else if (Input.GetKey(KeyCode.D))
                {
                    Debug.Log("was");
                    transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * velocity);
                }
                else
                {
                    transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * velocity);
                }
            }

            else if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * velocity);
            }

            else if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * velocity);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                rigidbody.AddForce(transform.up * jumpPower);
            }
        }
    }
        
}