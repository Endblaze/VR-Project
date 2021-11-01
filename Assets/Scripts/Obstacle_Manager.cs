using UnityEngine;

public class Obstacle_Manager : MonoBehaviour
{

    private float speed = 5;

    private Vector3 initialPos;

    private float floorX, objX;

    private void Awake()
    {

        floorX = GameObject.FindGameObjectWithTag("Floor").transform.localScale.x * 10;
        objX = transform.localScale.x;

        initialPos = new Vector3(0, transform.localScale.y / 2, 35);

    }

    void Update()
    {

        Movement();

        if(transform.position.z < -20)
        {

            NewPosition();
            
        }

    }

    private void Movement()
    {

        transform.position += new Vector3(0, 0, 1) * -speed * Game_Controller.Instance.speed * Time.deltaTime;

    }

    private void NewPosition()
    {

        Vector3 newPos = initialPos;

        newPos.x = Random.Range(-(floorX / 2 - objX / 2), floorX / 2 - objX / 2);

        transform.position = newPos;
        transform.Rotate(new Vector3(0, Random.Range(0,360), 0));

    }

}