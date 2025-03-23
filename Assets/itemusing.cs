using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemusing : MonoBehaviour
{
        public bool flashing = false;
    public GameObject flashlight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)) {
            if(flashing) {
                flashing = false;
            } else {
                flashing = true;
            }
        }
        flash_onoff(flashing);
    }

    private void flash_onoff(bool a) {
        flashlight.SetActive(a);
    }
}
