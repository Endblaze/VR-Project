using UnityEngine;

public class Player_Controller : MonoBehaviour
{

    private float speed = 10;

    private void Update()
    {

        if (Game_Controller.Instance.end) { return; }

        Movement();

    }

    private void Movement()
    {

        Vector3 forward = Camera.main.transform.forward;

        forward.y = 0;
        forward.z = 0;

        transform.position += forward * speed * Game_Controller.Instance.speed * Time.deltaTime;

    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Obstacle")
        {

            Game_Controller.Instance.end = true;

        }
        
        if(other.tag == "Coin")
        {

            Game_Controller.Instance.AddScore(10);

            other.gameObject.SetActive(false);

        }

    }

}