using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    Animator unitychanAnimator;

    GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        unitychanAnimator = GetComponent<Animator>();

        cube = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        AttackGetkey();
    }

    public void AttackGetkey()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            StartCoroutine("JabIE");
        }
    }

    public void AttackJab()
    {
        StartCoroutine("JabIE");
    }

    public IEnumerator JabIE()
    {
        var nowPosition = transform.position;
        var targetPosition = cube.transform.position;
        targetPosition.x = -3.6f;
        targetPosition.y = 0f;
        transform.position = targetPosition;

        unitychanAnimator.SetTrigger("Jab");
        yield return new WaitForSeconds(0.8f);

        var distance = targetPosition - nowPosition;

        var returnStep = 3;

        for (int i = 0; i < returnStep; i++)
        {
            var step = distance.magnitude / returnStep;
            transform.position = Vector3.MoveTowards
                (transform.position, nowPosition, step);
            yield return new WaitForSeconds(0.005f);
        }
    }


    public void AttackExplosion()
    {
        StartCoroutine("ExplosionIE");
    }
    public IEnumerator ExplosionIE()
    {
        var nowPosition = transform.position;
        var targetPosition = cube.transform.position;

        var magic = transform.Find("Magic").gameObject;

        magic.transform.position = targetPosition;

        magic.transform.Find("Explosion").gameObject.SetActive
            (true);

        yield return new WaitForSeconds(10.8f);

        magic.transform.Find("Explosion").gameObject.SetActive
            (false);

        /*
        var distance = targetPosition - nowPosition;

        var returnStep = 3;

        for (int i = 0; i < 10; i++)
        {
            var step = distance.magnitude / returnStep;
            transform.position = Vector3.MoveTowards
                (transform.position, nowPosition, step);
            yield return new WaitForSeconds(0.005f);
        }
        */
    }

}
