using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 _rotate;
    IEnumerator Start()
    {
        var body = GetComponent<Rigidbody>();
        while (true)
        {
            body.transform.Rotate(_rotate * Time.deltaTime);
            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
