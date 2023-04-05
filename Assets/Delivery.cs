using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float destroyDelay = 0.5f;
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 255);
    [SerializeField] Color32 noPackageColor = new Color32(0, 0, 0, 255);

    SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Collision");
    }

    void OnTriggerEnter2D(Collider2D other) {

        if (other.tag == "Package" && !hasPackage) {
            hasPackage = true;
            Debug.Log("hasPackage: " + hasPackage);

            // Change subject color
            spriteRenderer.color = hasPackageColor;

            // Destroy passed object
            Destroy(other.gameObject, destroyDelay);
        }

        if (other.tag == "Destiny" && hasPackage) {
            hasPackage = false;
            Debug.Log("hasPackage: " + hasPackage);

            // Change subject color
            spriteRenderer.color = noPackageColor;
        }
    }
}
