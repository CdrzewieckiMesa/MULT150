using UnityEditor;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        int count = 0;
        /* This is for step 11.6.
        for (int i = 0; i < 10; i++)
        {
            count++;
            print(count);
            Instantiate(prefab);
        }
        */

        for (var i = 0; i < 10; i++)
        {
            Instantiate(prefab, new Vector3(count * 3.16f, 0, 0), Quaternion.identity);
            count++;
        }

    }

    void Update()
    {
        // Whenever we hit the B key we will generate a prefab at the
        // position of the original prefab
        // Whenever we hit the space key, we will generate a prefab at the
        // position of the spawn object that this script is attached to
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}