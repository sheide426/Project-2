using UnityEngine;

public class BasicAI : MonoBehaviour
{

    public Transform target;
    public Transform myTransform;



    void Update()
    {

        transform.LookAt(target);
        transform.Translate(Vector3.forward * 5 * Time.deltaTime);

    }
}

