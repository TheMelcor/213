using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadSceneTrigger : MonoBehaviour {

    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            int index = SceneManager.GetActiveScene().buildIndex;
            index += 1;
            if ((index+1) > SceneManager.sceneCountInBuildSettings)
            {
                index = 0;
            }
            LoadByIndex(index);
        }
    }

    private void LoadByIndex(int index)
    {
        SceneManager.LoadScene(index);
    }
}
