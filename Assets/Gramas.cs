using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gramas : MonoBehaviour
{
  private AudioSource sound;
  private BoxCollider2D col;

  void Awake(){

    col = GetComponent<BoxCollider2D>();
    sound = GetComponent<AudioSource>();

  }

void OnTriggerEnter2D(Collider2D collider) {
    if(collider.gameObject.CompareTag("Player")){
        sound.Play();
        col.enabled = false;
        
    }
}
}
