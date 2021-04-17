using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//--------------------Professor, no dia da entrega do ***PARTE 1*** ENTREGA 01/04/21 e do ***PARTE 2*** ENTREGA 10/04/21, acabei viajando e nao pude enviar as tarefas,
//porem havia feito todas, vc conseguiria considerar pelo menos o da parte 2 valendo menos nota?


public class FollowPath : MonoBehaviour
{
    //criando as variaveis
    public GameObject wpManager;
    GameObject[] wps;
    NavMeshAgent agent;

    //Transform goal;
    //float speed = 5.0f;
    //float accuracy = 1.0f;
    //float rotSpeed = 2.0f;
    //GameObject currentNode;
    //int currentWP = 0;
    //Graph g;

    void Start()
    {
        //pegando o navmeshagent ao iniciar o script
        agent = GetComponent<NavMeshAgent>();
        //pegando as variaveis do script WPManager e adicioando ao script
        wps = wpManager.GetComponent<WPManager>().waypoints;

        //pegando as variaveis do script WPManager e adicioando ao script
        //g = wpManager.GetComponent<WPManager>().graph;
        //currentNode = wps[0];
    }

    //criando um metodo para fazer o tanque ir para o heliporto
    public void GoToHeli()
    {
        //setando o desitno no navmesh agent com o waypoint
        agent.SetDestination(wps[0].transform.position);

        //g.AStar(currentNode, wps[0]);
        //currentWP = 0;
    }
    //criando um metodo para fazer o tanque ir para o ruinas
    public void GoToRuin()
    {
        //setando o desitno no navmesh agent com o waypoint
        agent.SetDestination(wps[10].transform.position);

        //g.AStar(currentNode, wps[10]);
        //currentWP = 0;
    }
    //criando um metodo para fazer o tanque ir para o tanques
    public void GoToTanks()
    {
        //setando o desitno no navmesh agent com o waypoint
        agent.SetDestination(wps[6].transform.position);

        //g.AStar(currentNode, wps[6]);
        //currentWP = 0;
    }

    void LateUpdate()
    {
        //if(g.getPathLength() == 0 || currentWP == g.getPathLength())
        //{
        //    return;
        //}
        //currentNode = g.getPathPoint(currentWP);

        //if(Vector3.Distance(g.getPathPoint(currentWP).transform.position, transform.position) < accuracy)
        //{
        //    currentWP++;
        //}
        //if(currentWP < g.getPathLength())
        //{
        //    goal = g.getPathPoint(currentWP).transform;
        //    Vector3 lookAtGoal = new Vector3(goal.position.x, this.transform.position.y, goal.position.z);
        //    Vector3 direction = lookAtGoal - this.transform.position;
        //    // fazendo o tanque virar para o waypoint
        //    this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotSpeed);
        //    // fazendo o tanque ir ate o waypoint
        //    this.transform.Translate(0, 0, speed * Time.deltaTime);
        //}
    }
}
