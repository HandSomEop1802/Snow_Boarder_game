using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
 
{
     [SerializeField] float MagicNumber = 0.05f;
     [SerializeField] ParticleSystem CrashEffect;  
     [SerializeField] AudioClip CrashSFX;

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground")
        {
         CrashEffect.Play(); 
         
         Invoke ("ReloadSkin" , MagicNumber);
         GetComponent<AudioSource>().PlayOneShot(CrashSFX);
        }
   }
    void ReloadSkin()
    {
        SceneManager.LoadScene(0);
    }
}