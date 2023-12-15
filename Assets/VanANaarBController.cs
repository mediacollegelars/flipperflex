using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanANaarBController : MonoBehaviour
{
    [SerializeField] GameObject A;
    [SerializeField] GameObject B;
    [SerializeField] GameObject Ball;
    [SerializeField] GameObject Target;
    [SerializeField] float speed;

     void Start()
    {
        Ball.transform.position = A.transform.position;
        Target = B;

    }

    void Update()
    {
        Vector3 delta = Target.transform.position - Ball.transform.position;
        Ball.transform.position += delta.normalized *speed* Time.deltaTime;

        if (delta.magnitude < 0.1f) {
            Target = Target == A ? B : A;
         

        }
    }

}
