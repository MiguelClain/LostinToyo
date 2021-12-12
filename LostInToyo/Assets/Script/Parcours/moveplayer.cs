using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class moveplayer : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public Rigidbody2D rb;
    private bool isJumping = false;
    private Vector3 veloce = Vector3.zero;
    public float jump;
    private bool sol;
    public Transform solgauche;
    public Transform soldroit;

    public GameObject GameOver;
    public static bool isDead;
    public AudioSource audioSource;

    public Text mort;
    public GameObject Splashy;
    public GameObject Mort;


    private void Start()
    {
        transform.position = new Vector3(-7,-15,-95);
        isDead = false;
        Splashy.SetActive(false);
        Mort.SetActive(false);
    }
    void Update()
    {
        if (TutoScript.isplaying)
        {
            Splashy.SetActive(true);
            Mort.SetActive(true);
        }

        sol = Physics2D.OverlapArea(solgauche.position, soldroit.position);
        float horizontalmv = Input.GetAxis("Horizontal") * speed * Time.deltaTime*4;
        if (Input.GetButtonDown("Jump") && sol)
        {
            isJumping = true;
        }
        Deplace(horizontalmv);

        mort.text = "Mort : " + MainMenu.mort.ToString();

    }

    void Deplace(float mv)
    {
        Vector3 velocity = new Vector2(mv, rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, velocity,ref veloce, 0.01f);
        if(isJumping == true)
        {
            rb.AddForce(new Vector2(0f, jump));
            isJumping = false;
        }
    }

    void OnBecameInvisible()
    {
        GameOver.SetActive(true);
        isDead = true;
        audioSource.Stop();
        Time.timeScale = 0f;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
    }
    }
