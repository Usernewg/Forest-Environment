using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov: MonoBehaviour
{

    public CharacterController Character;
    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        Character = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        Vector3 Move = new Vector3(Horizontal, 0, Vertical);
        Character.Move(Move * speed * Time.deltaTime);

        // }
    }
}