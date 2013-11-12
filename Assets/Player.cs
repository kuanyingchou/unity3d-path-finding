using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
        
    private NavMeshAgent agent;
    
    void Start () {
        agent = GetComponent<NavMeshAgent>();
    }
    
    void Update () {
        agent.destination = 
                GameObject.Find("Target").transform.position;
    }
}
