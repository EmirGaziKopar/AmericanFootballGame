using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Transform sceneTransform;

    Animator anim;
    [SerializeField] GameObject Character;
    new Rigidbody rigidbody;

    private void Start()
    {
        anim = Character.GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (this.anim.GetCurrentAnimatorStateInfo(0).IsName("shot"))
        {
            Debug.Log("not playing");
            transform.parent = sceneTransform.transform;
        }
        else
        {
            Debug.Log("playing");
        }
        

    }
}
