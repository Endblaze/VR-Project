using UnityEngine;

public class Spider_Manager : MonoBehaviour
{

    public Transform target;

    private Animator anim;

    private bool attack;

    private void Awake()
    {

        anim = GetComponent<Animator>();

    }

    private void Update()
    {

        LookAtPlayer();

        if (Game_Controller.Instance.end)
        {
            GameOver();
        }

    }

    private void LateUpdate()
    {

        if (attack)
        {
            anim.SetBool("Attack", attack);
        }

    }

    private void LookAtPlayer()
    {

        Vector3 pos = target.position;
        pos.y = 0;

        transform.LookAt(pos);

    }

    private void GameOver()
    {

        if((transform.position.z + 2) < target.transform.position.z)
        {

            transform.position += new Vector3(0, 0, 5) * Time.deltaTime;
        
            if(transform.position.x < target.transform.position.x)
            {
                transform.position += new Vector3(5, 0, 0) * Time.deltaTime;
            }
            else
            {
                transform.position += new Vector3(-5, 0, 0) * Time.deltaTime;
            }

        }
        else
        {
            attack = true;
        }

    }

    private void OnTriggerStay(Collider other)
    {
        
        if(other.tag == "Obstacle")
        {

            other.transform.position += new Vector3(Mathf.Sign(other.transform.position.x), 0, 0) * Time.deltaTime * 5;

        }

    }

}