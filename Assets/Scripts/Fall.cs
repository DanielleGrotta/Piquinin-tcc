using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Fall : MonoBehaviour
{

    
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("GameOver");
            PermanentUI.perm.Reset();
        }
    }
}
