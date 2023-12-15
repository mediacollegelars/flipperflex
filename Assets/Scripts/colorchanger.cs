using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colourchanger : MonoBehaviour
{
    [SerializeField] MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeColor()
    {
    meshRenderer.material.color = Color.blue;
        }
}
