using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Transform sceneTransform;

    // public GameObject normalCamera, ballCamera;    Topu attýktan sonra topu takip eden kamera düþüncesi düþüncesi
       Transform Bodytransform;
    [SerializeField] float speed;
    Animator anim;
    [SerializeField] GameObject Character;
    new Rigidbody rigidbody;
    bool isFlaying = false;
    new ParticleSystem particleSystem;
    [SerializeField] GameObject particleSystemPointer;
    public float baslangic = 0f;
    [SerializeField] GameObject cube;

    private void Start()
    {
        anim = Character.GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
        Bodytransform = cube.GetComponent<Transform>();
        particleSystem = particleSystemPointer.GetComponent<ParticleSystem>();
        var emission = particleSystem.emission;
        emission.rateOverTime = baslangic;
    }

    private void FixedUpdate()
    {
        
        if (this.anim.GetCurrentAnimatorStateInfo(0).IsName("shot"))
        {     
            transform.rotation = Quaternion.Euler(0, 0, 0);
            Debug.Log("not playing");
            transform.parent = sceneTransform.transform;
            rigidbody.constraints = RigidbodyConstraints.None;
            rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
            transform.Translate(transform.forward * Time.deltaTime * speed);
            shot();
            var emission = particleSystem.emission;
            emission.rateOverTime = 500f;
        }
        else
        {
            Debug.Log("playing");
        }
        
        
    }
 /*
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("stadium") || other.gameObject.CompareTag("character"))
        {
            isFlaying = false;
            normalCamera.gameObject.SetActive(true);
            ballCamera.gameObject.SetActive(false);


        }
        else
        {

            onFly();




        }
    }
   
    
    void onFly()
    {


        normalCamera.gameObject.SetActive(false);
        ballCamera.gameObject.SetActive(true);


    }
 */
    void shot()
    {
        Vector3 a = new Vector3(Bodytransform.forward.x, 0.5f,  Bodytransform.forward.z); //Topun karsiya gitmesini saglayan z.
        
        rigidbody.velocity = a * speed;
    }
}
