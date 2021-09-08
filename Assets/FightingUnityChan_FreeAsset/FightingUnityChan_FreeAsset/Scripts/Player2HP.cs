using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2HP : HPScript
{
    // Start is called before the first frame update
    void Start()
    {
        base.SetSlider(500f);
    }

    // Update is called once per frame
    void Update()
    {
        base.Damage(Input.GetKeyDown(KeyCode.Alpha3));
    }
}
