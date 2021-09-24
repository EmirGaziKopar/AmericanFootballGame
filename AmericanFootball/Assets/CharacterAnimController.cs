using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimController : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Buraya girildi");
            anim.SetBool("shot", true);
            

        }
        else
        {
            anim.SetBool("shot", false);
        }
        
        /*if (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
        {
            anim.SetBool("shot", false);
        }
        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1) //animasyonu durduktan sonra false yap demek istedik bu nedenle animasyon bitmeden tekrar sol click dahi yapsanýz animasyon baþlamayacaktýr.
        {  //If normalizedTime is 0 to 1 means animation is playing, if greater than 1 means finished
            Debug.Log("not playing");
            anim.SetBool("shot", false);
        }*/


    }
}
