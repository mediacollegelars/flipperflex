using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateleft : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(4, 2, 0);
    }
}
