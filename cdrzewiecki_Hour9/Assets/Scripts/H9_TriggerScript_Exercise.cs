using UnityEditor;
using UnityEngine;

public class H9_TriggerScript_Exercise : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + " has entered the " + gameObject.name);
    }
    void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name + " is still in the " + gameObject.name);
    }

    void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name + " has left the " + gameObject.name);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}