using UnityEngine;
using UnityEngine.AI; // adicionada a biblioteca da unity refente ao uso do NavMesh

public class Waypoint : MonoBehaviour
{
    // Declarando todas as variaveis
    [SerializeField]
    GameObject[] locations;

    NavMeshAgent nav;

    int i = 0;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>(); // Pegando NavMeshAgent do player ao iniciar o script e adicionando a variavel nav

        InvokeRepeating("changeLocation", 1, 4); // Invocando o metodo a cada 4 segundos durando 1 segundo
    }

    //criando uma funcao para chamar a troca de posicao
    void changeLocation()
    {
        ++i;
        if (i == locations.Length) // Verificando se o valor incrementado é maior que a quantidade de waypoints
        {
            i  = 0; // Se for igual, recomeca a variavel de incremento
        }

        nav.SetDestination(locations[i].transform.position); // Colocando a localizacao dos waypoints no Navmesh
    }
}
