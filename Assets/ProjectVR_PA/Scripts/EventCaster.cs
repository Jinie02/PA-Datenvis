using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventCaster : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
     if(Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;

            if(Physics.Raycast(Camera.main.ScreenPointToRay(new Vector3(Screen.width/2, Screen.height/2, Camera.main.nearClipPlane)), out hit, 1000))
            {
                if(hit.collider.CompareTag("Door"))
                {
                    var h= hit.collider.transform.GetComponent<Animator>().GetBool("open");
                    hit.collider.transform.GetComponent<Animator>().SetBool("open", !h);
                }
            }
        }
    }
}
