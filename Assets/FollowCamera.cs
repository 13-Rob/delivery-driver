using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject subject;
    // Camera follows the main car
    void Update()
    {
        transform.position = subject.transform.position - new Vector3 (0, 0, 20);
    }
}
