using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Player : MonoBehaviour
{
    // Speed of Camera Movement
    private Animator animator;
    private NavMeshAgent agent;
    private float pitch = 0.0f;

    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();

    }
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.forward * z * agent.speed;
        transform.Rotate(0f, x, 0f);
        agent.Move(move * Time.deltaTime);
        animator.SetFloat("Speed", move.magnitude);
    }
}
