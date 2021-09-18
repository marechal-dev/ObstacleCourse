using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropObject : MonoBehaviour
{
    MeshRenderer dropperMeshRenderer;
    Rigidbody dropperRigidBody;

    [SerializeField] float timeToWait = 3f;

    void Awake()
    {
        dropperMeshRenderer = GetComponent<MeshRenderer>();
        dropperRigidBody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        dropperMeshRenderer.enabled = false;
        dropperRigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            dropperMeshRenderer.enabled = true;
            dropperRigidBody.useGravity = true;
        }
    }
}
