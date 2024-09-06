using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("I am a component added to the prefab");
    }

    [SerializeField] private float xMove = 0.0f;
    [SerializeField] private float yMove = 0.0f;
    [SerializeField] private float zMove = 0.0f;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(xMove, yMove, zMove) * Time.deltaTime;
        Debug.Log("I update with every frame of the prefab");
    }
}
