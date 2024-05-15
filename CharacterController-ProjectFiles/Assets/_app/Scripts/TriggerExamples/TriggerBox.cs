using System;
using UnityEngine;

namespace _app.Scripts.TriggerExamples
{
    public class TriggerBox : MonoBehaviour
    {
        [SerializeField]
        private int count;
        
        public void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                Debug.Log(message:other.transform.name + " Entered Trigger");
            }
        }

        public void OnTriggerExit(Collider other)
        {
            Debug.Log(message:other.transform.name + " Exited Trigger");
        }

        public void OnCollisionEnter(Collision other)
        {
            Debug.Log(message:"Collided with Object");
        }

        public void OnCollisionExit(Collision other)
        {
            Debug.Log(message:"No Longer Colliding With Object");
        }
    }

}
