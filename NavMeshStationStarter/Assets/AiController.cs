using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiController : MonoBehaviour
{
    public NavMeshAgent agent;

    void Start()
    {
        // chama o componente
        agent = this.GetComponent<NavMeshAgent>();
    }
}
