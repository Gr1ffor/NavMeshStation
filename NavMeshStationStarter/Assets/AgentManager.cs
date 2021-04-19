using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    GameObject[] agents;
    void Start()
    {
        // procura a tag
        agents = GameObject.FindGameObjectsWithTag("ai");
    }

    void Update()
    {
        // se dar um clique com o botão do mouse
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            // o objeto anda até o local
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                foreach (GameObject a in agents)
                    a.GetComponent<AiController>().agent.SetDestination(hit.point);
            }
        }
    }
}
