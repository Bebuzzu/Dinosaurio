using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidbody;
    [SerializeField] Animator animator;
    float alturaSalto = 500f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigidbody.AddForce(Vector2.up * alturaSalto);
            animator.SetBool("estaEnSuelo", true);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetBool("estaEnSuelo", false);
    }
}
