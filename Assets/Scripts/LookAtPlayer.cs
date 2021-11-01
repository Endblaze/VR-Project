using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{

    public Transform target;

    private void Update()
    {

        transform.LookAt(target);

        if (tag == "Score") { return; }

        transform.position = target.position + Camera.main.transform.forward * 5;

    }

}