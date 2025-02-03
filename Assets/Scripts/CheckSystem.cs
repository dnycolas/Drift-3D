using System.Collections.Generic;
using UnityEngine;

public class CheckSystem : MonoBehaviour
{
    public GameObject player;

    public List<GameObject> CheckPoints;

    public Vector3 SpawnPoint;

    public float EixoLimite;


    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < EixoLimite || Input.GetKeyDown(KeyCode.E))
        {
            player.transform.position = SpawnPoint;
            player.transform.eulerAngles = new Vector3(0,0,transform.eulerAngles.z);
            
        }
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Piso"))
        {

            SpawnPoint = other.transform.position;
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("matador"))
        {
            transform.position = (SpawnPoint);
              
        }

    }

}
