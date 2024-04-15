using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayer : MonoBehaviour
{
    [SerializeField] public float playerSpeed;
    private void Update()
    {
        transform.localPosition += transform.forward * playerSpeed  * Time.deltaTime;
    }
}
