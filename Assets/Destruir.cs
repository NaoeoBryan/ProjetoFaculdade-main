using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{
   public GameObject space;  


    void Start(){

        Destroy(space, 3f);
    }

}
