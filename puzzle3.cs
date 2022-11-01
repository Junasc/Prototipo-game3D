using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;

public class puzzle3 : MonoBehaviour {

   public Canvas exemplo3;

   void Start()
   {
      exemplo3.GetComponent<Canvas>().enabled = false;
   }

   void Update ()
   {
      if (Input.GetMouseButton (0)) {
         Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
         RaycastHit hit;
         if (Physics.Raycast (ray, out hit)) {
            if (hit.transform.name == "puzzle3") {
               exemplo3.GetComponent<Canvas> ().enabled = true;
            }
         }
         
      }

   }
}