using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    private CharacterController controller;
    private float speed = 0.1f;
    private Vector3 moveVector;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    public void Canwalk()
    {
        controller.Move(Vector3.forward * speed * Time.deltaTime);
        moveVector.x = speed;

        moveVector = Vector3.zero;
        controller.Move((moveVector) * Time.deltaTime);
        
    }
}
