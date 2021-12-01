using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    [SerializeField] private float cameraSpeed = 2f;
  private Animator animator;
  private float pitch = 0.0f;

void Start(){
  animator=GetComponent<Animator>();
}

    // Update is called once per frame
    void Update() {

 var velocity = transform.forward * Input.GetAxis("Vertical");
      GetComponent<NavMeshAgent>().destination = transform.position+velocity;


        animator.SetFloat("Speed", velocity.magnitude);
            pitch-= Input.GetAxis("Mouse X") * cameraSpeed;
         transform.eulerAngles = new Vector3(0.0f, pitch, 0.0f);

    }
}
