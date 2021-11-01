using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject obstacle, coin;

    private float interval1 = 2, timer1 = 2, amount1 = 6;
    private float interval2 = 1.5f, timer2 = 1.5f, amount2 = 6;

    private void Update()
    {

        if(amount1 > 0)
        {

            if(timer1 >= interval1)
            {

                GameObject obj = Instantiate(obstacle, transform.position, Quaternion.identity);
                obj.transform.parent = transform;

                amount1--;
                timer1 = 0;

            }
            else
            {
                timer1 += Time.deltaTime;
            }

        }

        if (amount2 > 0)
        {

            if (timer2 >= interval2)
            {
                GameObject obj = Instantiate(coin, transform.position, Quaternion.identity);
                obj.transform.parent = transform;

                amount2--;
                timer2 = 0;
            }
            else
            {
                timer2 += Time.deltaTime;
            }

        }

    }

}