using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pallra : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform cameraTransform;
    private Vector3 lastCameraPosition;
    [SerializeField] private float parallaxEffect=5f;
    
    void Start()
    {
        cameraTransform = Camera.main.transform;
        lastCameraPosition = cameraTransform.position;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;
        transform.position += deltaMovement * parallaxEffect;
        lastCameraPosition = cameraTransform.position;
    }
}
