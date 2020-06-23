using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullableTest : MonoBehaviour
{
    private Transform tr;
    private AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>() ?? gameObject.AddComponent<AudioSource>();      


    }

}
