using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Clicktomove : MonoBehaviour{
    private Animator Manimator;
    private NavMeshAgent Mnavmesh;
    private bool Mrunning;
    private bool comando;

    void Start(){
        Manimator = GetComponent<Animator>();
        Mnavmesh = GetComponent<NavMeshAgent>();

    }
    void OnMouseDown(){
        comando = !comando;
    }
    void Update(){
        if (comando == true){
            Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
            RaycastHit hit;
            if  (Input.GetMouseButtonDown (0)){
                if(Physics.Raycast (ray, out hit, 100)){
                    Mnavmesh.destination = hit.point;
                }
            }
        }
        if (Mnavmesh.remainingDistance <= Mnavmesh.stoppingDistance){
            Mrunning = false;
        } else{
            Mrunning = true;
        }
        Manimator.SetBool("running" , Mrunning);
    }
}

