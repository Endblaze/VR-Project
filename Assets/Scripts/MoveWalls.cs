using UnityEngine;

public class MoveWalls : MonoBehaviour
{
    
    private Renderer rend;

    private float speed;

    private void Awake()
    {
        
        rend = GetComponent<Renderer>();

    }

    private void Update()
    {

        speed = Time.deltaTime / 2 * Game_Controller.Instance.speed;

        if (tag != "Floor")
        {

            rend.material.mainTextureOffset += new Vector2(speed, 0);

        }
        else
        {

            rend.material.mainTextureOffset += new Vector2(0, -speed);

        }

    }

}