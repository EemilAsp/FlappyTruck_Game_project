using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Truck : MonoBehaviour
{
    public float velocity = 6;
    public Rigidbody2D truckRigidBody;
    public LogicScript logic;
    public bool engineWorking = true;
    [SerializeField] private AudioSource jumpSoundEffect;
    

    // Start is called before the first frame update
    void Start()
    {
        truckRigidBody = GetComponent<Rigidbody2D>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") && engineWorking == true)
        {
            truckRigidBody.velocity = Vector2.up * velocity;
            jumpSoundEffect.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        logic.gameOver();
        engineWorking = false;
    }
}
