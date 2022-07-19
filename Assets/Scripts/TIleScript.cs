using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIleScript : MonoBehaviour
{

    public GameObject Tile;
    private Animator anim;
    bool steppedOn = false;
    bool steppedOnOrange = false;
    Move2D player = null;
    bool painted = false;
    bool paintedOrange = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Move2D>();
        anim = Tile.GetComponent<Animator>();
    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (Input.GetKey(KeyCode.LeftShift) && other.gameObject.CompareTag("Player"))
        {
            player.jumpHeight = 18f;
            anim.SetBool("steppedOn", true);
            anim.SetBool("steppedOnOrange", false);
            painted = true;
            paintedOrange = false;
        }

        if (Input.GetKey(KeyCode.LeftControl) && other.gameObject.CompareTag("Player"))
        {
            player.moveSpeed = 15f;
            anim.SetBool("steppedOnOrange", true);
            anim.SetBool("steppedOn", false);
            paintedOrange = true;
            painted = false;
        }

        if (other.gameObject.CompareTag("Player") && painted)
        {
            player.jumpHeight = 18f;
        }

        if (other.gameObject.CompareTag("Player") && !painted)
        {
            player.jumpHeight = 8f;
        }

        if (other.gameObject.CompareTag("Player") && paintedOrange)
        {
            player.moveSpeed = 15f;
        }

        if (other.gameObject.CompareTag("Player") && !paintedOrange)
        {
            player.moveSpeed = 8f;
        }
    }

}
