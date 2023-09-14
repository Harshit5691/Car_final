using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine_disapp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animator anim = gameObject.GetComponent<Animator>();
        anim.Play("EngineDisappear", -1, float.NegativeInfinity);
    }

    // Update is called once per frame
    void Update()
    {
        Animator anim = gameObject.GetComponent<Animator>();
        anim.SetFloat("direction", -1);
        anim.Play("EngineDisappear", -1, float.NegativeInfinity);
    }
}
