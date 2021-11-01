using UnityEngine;

public class ShowScore : MonoBehaviour
{

    public TextMesh txtScore;

    private void Awake()
    {

        txtScore.text = "Last Score: " + PlayerPrefs.GetFloat("LastScore") + "\nRecord: " + PlayerPrefs.GetFloat("Record");

    }

}