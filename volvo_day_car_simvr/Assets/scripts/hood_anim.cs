using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hood_anim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animator anim = gameObject.GetComponent<Animator>();
        anim.Play("lol", -1, float.NegativeInfinity);
    }

    // Update is called once per frame
    void Update()
    {
        Animator anim = gameObject.GetComponent<Animator>();
        anim.SetFloat("Direction", -1);
        anim.Play("lol",-1,float.NegativeInfinity);
    }
}
