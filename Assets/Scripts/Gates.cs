using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gates : MonoBehaviour
{
    // Start is called before the first frame update
    private int Goals;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Ball>(out Ball ball))
        {
            Goals += 1;
            Debug.Log($"Goal! Count: {Goals}");
            Destroy(other.gameObject);
        }
    }
}
