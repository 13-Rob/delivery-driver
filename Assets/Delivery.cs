using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float destroyDelay = 0.5f;

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Collision");
    }

    void OnTriggerEnter2D(Collider2D other) {

        if (other.tag == "Package" && !hasPackage) {
            hasPackage = true;
            Debug.Log("hasPackage: " + hasPackage);
            Destroy(other.gameObject, destroyDelay);
        }

        if (other.tag == "Destiny" && hasPackage) {
            hasPackage = false;
            Debug.Log("hasPackage: " + hasPackage);
        }
    }
}
