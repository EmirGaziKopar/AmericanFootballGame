using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Transform sceneTransform;


    Transform Bodytransform;
    [SerializeField] float speed;
    Animator anim;
    [SerializeField] GameObject Character;
    new Rigidbody rigidbody;

    [SerializeField] GameObject cube;

    private void Start()
    {
        anim = Character.GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();

        Bodytransform = cube.GetComponent<Transform>();
    }

    private void Update()
    {
        if (this.anim.GetCurrentAnimatorStateInfo(0).IsName("shot"))
        {
            Debug.Log("not playing");
            transform.parent = sceneTransform.transform;
            rigidbody.constraints = RigidbodyConstraints.None;

            rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
            transform.Translate(transform.forward * Time.deltaTime * speed);
            shot();
        }
        else
        {
            Debug.Log("playing");
        }
        

    }

    void shot()
    {
        Vector3 a = new Vector3(Bodytransform.forward.x, Random.Range(0.001f, 0.002f), Bodytransform.forward.z); //Topun karsiya gitmesini saglayan z.
        rigidbody.velocity = a * speed;
    }
}
