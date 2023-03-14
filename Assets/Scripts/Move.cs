using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody _rigidbody;

   
    public float normalspeed;  //vitesse de base
    
    public float speed; // vitesse actuel

    public float speedbonusMultiplicator= 1.5f;

    public float bonusTime = 4f;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Acceleration")
        {
            // action déclencher qui est accélérer la vitesse

            speed = normalspeed * speedbonusMultiplicator;

        }
    }


    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0f || Input.GetAxis("Vertical") != 0f)
        {
            _rigidbody.AddForce(Input.GetAxis("Horizontal") * 0.5f, 0f, Input.GetAxis("Vertical"));
        }

        transform.Translate(0, 0, 1 * speed * Time.deltaTime); // L'avancement de la ball. Pour qu'elle se déplace seule
    }
}
