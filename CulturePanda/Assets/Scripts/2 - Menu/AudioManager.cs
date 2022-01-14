 using UnityEngine;
 
 public class AudioManager : MonoBehaviour
 {
     private AudioSource _audioSource;
     public void Awake(){
         GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
            if(objs.Length > 1)
                Destroy(this.gameObject);
            
            DontDestroyOnLoad(this.gameObject);
     }

     public bool isPlaying(){
         _audioSource = GetComponent<AudioSource>();
         return _audioSource.isPlaying;
     }
     public void PlayMusic(){
         _audioSource = GetComponent<AudioSource>();
         if (_audioSource.isPlaying) return;
         _audioSource.Play();
     }
 
     public void StopMusic(){
         _audioSource = GetComponent<AudioSource>();
         _audioSource.Stop();
     }
 }