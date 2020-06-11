using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopDestroying : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
