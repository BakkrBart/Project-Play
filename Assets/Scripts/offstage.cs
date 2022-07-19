using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offstage : MonoBehaviour
{ 
        public float thresholdY = -2;
        public float resetHeightY = 1;
        public float resetHeightX = -4;
        

        private void Update()
        {
            if (transform.position.y < thresholdY || Input.GetKey(KeyCode.R))
            {
            // Note, I keep the x and z position the same, as it sounds like that's what you were looking for. Change as needed
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
            }
        }
    
}
