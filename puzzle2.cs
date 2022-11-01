using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;

public class puzzle2 : MonoBehaviour {

   public Canvas exemplo;

   void Start()
   {
      exemplo.GetComponent<Canvas>().enabled = false;
   }

   void Update ()
   {
      if (Input.GetMouseButton (0)) {
         Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
         RaycastHit hit;
         if (Physics.Raycast (ray, out hit)) {
            if (hit.transform.name == "puzzle2") {
               exemplo.GetComponent<Canvas> ().enabled = true;
            }
         }
         
      }

   }
}