using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{

    public float VelocidadCaminar = 5;
    private Rigidbody2D MiCuerpo;
    private Animator MiAnimador;
    // Start is called before the first frame update
    void Start()
    {
        MiCuerpo = GetComponent<Rigidbody2D>();
        MiAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float velVert = MiCuerpo.velocity.y;

        float movHoriz = Input.GetAxis("Horizontal");

        if (movHoriz > 0)
        {//der
            transform.rotation = Quaternion.Euler(0, 0, 0);
            MiCuerpo.velocity = new Vector3(VelocidadCaminar, velVert, 0);
            MiAnimador.SetBool("CAMINANDO", true);
        }
        else if (movHoriz < 0)
        {//izq
            transform.rotation = Quaternion.Euler(0, 180, 0);
            MiCuerpo.velocity = new Vector3(-VelocidadCaminar, velVert, 0);
            MiAnimador.SetBool("CAMINANDO", true);
        }
        else
        {//no
            MiCuerpo.velocity = new Vector3(0, velVert, 0);
            MiAnimador.SetBool("CAMINANDO", false);
        }
    }
}
