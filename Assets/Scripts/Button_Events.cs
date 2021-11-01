using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Events : MonoBehaviour
{

    public int index;

    private bool selected;
    private Renderer rend;

    private void Awake()
    {

        rend = GetComponent<Renderer>();

    }

    private void Update()
    {

        if (selected)
        {

            if (rend.material.color.g < 1)
            {

                Color col = rend.material.color;

                col.g += Time.deltaTime / 1.5f;

                rend.material.color = col;

            }
            else
            {

                switch (index)
                {

                    case 0:
                        SceneManager.LoadScene("Game");
                        break;

                    case 1:
                        Application.Quit();
                        break;

                }

            }

        }

    }

    public void SelectButton()
    {

        selected = true;

    }

    public void DeselectButton()
    {

        selected = false;

        rend.material.color = Color.black;

    }

}
