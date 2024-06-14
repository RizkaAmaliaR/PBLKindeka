using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCfollow : MonoBehaviour
{
    public GameObject target;

    public GameObject currentTarget;

    public NavMeshAgent agent;

    public float range;

    public int maxRange;

    public Vector3 startPos;

    public GameObject UIWarning;
    public GameObject UIInfoWarning;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CheckDistance", 0, 0.5f);

        startPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        if (currentTarget != null)
        {
            agent.destination = currentTarget.transform.position;
            anim.SetBool("isWalking", true);
        }
        else if (agent.destination != startPos)
        {
            agent.destination = startPos;
        }

        // Check if the player is at the startPos
        if (Vector3.Distance(transform.position, startPos) < 0.1f)
        {
            anim.SetBool("isWalking", false);
        }
    }


    public void CheckDistance()
    {
        float distance = Vector3.Distance(this.transform.position, target.transform.position);

        if (distance < range)
        {
            currentTarget = target;
        }
        else if (distance > maxRange)
        {
            currentTarget = null;
        }

        float warning = range / 2;

        // Aktifkan UIWarning jika jarak adalah setengah dari range
        if (distance < warning)
        {
            UIWarning.SetActive(true);
            UIInfoWarning.SetActive(true);
        }
        else
        {
            UIWarning.SetActive(false);
            UIInfoWarning.SetActive(false);
        }
    }

}
