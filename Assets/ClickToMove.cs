using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickToMove : MonoBehaviour
{
    public NavMeshAgent agent;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
           Ray movePostion = Camera.main.ScreenPointToRay(Input.mousePosition);
           if(Physics.Raycast(movePostion, out var hitInfo))
              {
                agent.SetDestination(hitInfo.point);
              }
        }
    }
}
