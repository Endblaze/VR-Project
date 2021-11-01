using UnityEngine;

public class Coin_Manager : MonoBehaviour
{

    public GameObject particlesPref;

    private GameObject objParticle;
    private ParticleSystem sysParticle;

    private void Awake()
    {

        objParticle = Instantiate(particlesPref.gameObject);
        objParticle.transform.parent = GameObject.Find("Spawner").transform;

        sysParticle = objParticle.GetComponent<ParticleSystem>();
        
        sysParticle.Stop();

    }

    private void Update()
    {

        transform.Rotate(0, Time.deltaTime * 100, 0);

    }

    private void OnDisable()
    {

        if(objParticle == null) { return; }

        objParticle.transform.position = transform.position;

        sysParticle.Play();

        transform.position += new Vector3(0, 0, -10);

        Invoke("EnableObject", 2);

    }

    private void EnableObject()
    {

        gameObject.SetActive(true);

    }

}