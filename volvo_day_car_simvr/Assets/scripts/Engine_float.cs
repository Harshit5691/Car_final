using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine_float : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animator anim = gameObject.GetComponent<Animator>();
        anim.Play("EngineInspect", -1, float.NegativeInfinity);
    }

    // Update is called once per frame
    void Update()
    {
        Animator anim = gameObject.GetComponent<Animator>();
        anim.SetFloat("Direct", -1);
        anim.Play("EngineInspect", -1, float.NegativeInfinity);
    }
}
