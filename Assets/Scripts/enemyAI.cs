/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent ai;
    public List<Transform> destinations;
    public Animator aiAnim;
    public float walkSpeed, chaseSpeed, minIdleTime, maxIdleTime, idleTime, sightDistance, catchDistance, chaseTime, minChaseTime, maxChaseTime, jumpscareTime;
    public Vector3 rayCastOffset;
    public string deathScene;

    public enum EnemyState
    {
        Patrolling,
        Idle,
        Chasing
    }

    public EnemyState currentState;

    public Transform player;
    Transform currentDest;
    Vector3 dest;
    int randNum;
    public int destinationAmount;

    void Start()
    {
        randNum = Random.Range(0, destinations.Count);
        currentDest = destinations[randNum];
        SetState(EnemyState.Patrolling);
    }

    void Update()
    {
        Vector3 direction = (player.position - transform.position).normalized;
        RaycastHit hit;
        if (Physics.Raycast(transform.position + rayCastOffset, direction, out hit, sightDistance))
        {
            if (hit.collider.gameObject.tag == "Player")
            {
                SetState(EnemyState.Chasing);
            }
        }

        if (currentState == EnemyState.Chasing)
        {
            StopCoroutine("stayIdle");
            StopCoroutine("chaseRoutine");
            StartCoroutine("chaseRoutine");
            dest = player.position;
            ai.destination = dest;
            ai.speed = chaseSpeed;
            aiAnim.ResetTrigger("walk");
            aiAnim.ResetTrigger("idle");
            aiAnim.SetTrigger("sprint");
            float distance = Vector3.Distance(player.position, ai.transform.position);
            if (distance <= catchDistance)
            {
                player.gameObject.SetActive(false);
                aiAnim.ResetTrigger("walk");
                aiAnim.ResetTrigger("idle");
                aiAnim.ResetTrigger("sprint");
                aiAnim.SetTrigger("jumpscare");
                StartCoroutine(deathRoutine());
            }
        }
        else if (currentState == EnemyState.Patrolling)
        {
            
            dest = currentDest.position;
            ai.destination = dest;
            ai.speed = walkSpeed;
            aiAnim.ResetTrigger("sprint");
            aiAnim.ResetTrigger("idle");
            aiAnim.SetTrigger("walk");
            
            if (ai.remainingDistance <= ai.stoppingDistance)
            {
                
                
                SetState(EnemyState.Idle);
                StartCoroutine("stayIdle");
                
            }
            
        }
        else if (currentState == EnemyState.Idle)
        {
            aiAnim.ResetTrigger("sprint");
            aiAnim.ResetTrigger("walk");
            aiAnim.SetTrigger("idle");
            ai.speed = 0;
        }
    }

    void SetState(EnemyState newState)
    {
        currentState = newState;
    }

    IEnumerator stayIdle()
    {
        idleTime = Random.Range(minIdleTime, maxIdleTime);
        yield return new WaitForSeconds(idleTime);
        SetState(EnemyState.Patrolling);
        randNum = Random.Range(0, destinations.Count);
        currentDest = destinations[randNum];
    }

    IEnumerator chaseRoutine()
    {
        chaseTime = Random.Range(minChaseTime, maxChaseTime);
        yield return new WaitForSeconds(chaseTime);
        SetState(EnemyState.Patrolling);
        randNum = Random.Range(0, destinations.Count);
        currentDest = destinations[randNum];
    }

    IEnumerator deathRoutine()
    {
        yield return new WaitForSeconds(jumpscareTime);
        SceneManager.LoadScene(deathScene);
    }
}
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent ai;
    public List<Transform> destinations;
    public Animator aiAnim;
    public float walkSpeed, chaseSpeed, minIdleTime, maxIdleTime, idleTime, sightDistance, catchDistance, chaseTime, minChaseTime, maxChaseTime, jumpscareTime;
    public Vector3 rayCastOffset;
    public string deathScene;

    //
    public AudioSource footstepsAudioSource;
    public AudioClip wanderingFootstepsClip;
    public AudioClip chasingFootstepsClip;

    public AudioSource growlingAudioSource;
    public AudioClip wanderingGrowlClip;
    public AudioClip chasingGrowlClip;
    //
    public enum EnemyState
    {
        Patrolling,
        Idle,
        Chasing
    }

    public EnemyState currentState;

    public Transform player;
    Transform currentDest;
    Vector3 dest;
    int randNum;
    public int destinationAmount;

    void Start()
    {
        randNum = Random.Range(0, destinations.Count);
        currentDest = destinations[randNum];
        SetState(EnemyState.Patrolling);
        //
        footstepsAudioSource.clip = wanderingFootstepsClip;
        growlingAudioSource.clip = wanderingGrowlClip;
        footstepsAudioSource.Play();
        growlingAudioSource.Play();
        //
    }

    void Update()
    {
        Vector3 direction = (player.position - transform.position).normalized;
        RaycastHit hit;
        if (Physics.Raycast(transform.position + rayCastOffset, direction, out hit, sightDistance))
        {
            if (hit.collider.gameObject.tag == "Player")
            {
                SetState(EnemyState.Chasing);
            }
        }

        if (currentState == EnemyState.Chasing)
        {
            //
            if (!footstepsAudioSource.isPlaying || footstepsAudioSource.clip != chasingFootstepsClip)
            {
                footstepsAudioSource.clip = chasingFootstepsClip;
                footstepsAudioSource.Play();
            }

            if (!growlingAudioSource.isPlaying || growlingAudioSource.clip != chasingGrowlClip)
            {
                growlingAudioSource.clip = chasingGrowlClip;
                growlingAudioSource.Play();
            }
            //
            StopCoroutine("stayIdle");
            StopCoroutine("chaseRoutine");
            StartCoroutine("chaseRoutine");
            dest = player.position;
            ai.destination = dest;
            ai.speed = chaseSpeed;
            aiAnim.ResetTrigger("walk");
            aiAnim.ResetTrigger("idle");
            aiAnim.SetTrigger("sprint");
            float distance = Vector3.Distance(player.position, ai.transform.position);
            if (distance <= catchDistance)
            {
                player.gameObject.SetActive(false);
                aiAnim.ResetTrigger("walk");
                aiAnim.ResetTrigger("idle");
                aiAnim.ResetTrigger("sprint");
                aiAnim.SetTrigger("jumpscare");
                StartCoroutine(deathRoutine());
            }
        }
        else if (currentState == EnemyState.Patrolling)
        {
            //
            if (!footstepsAudioSource.isPlaying || footstepsAudioSource.clip != wanderingFootstepsClip)
            {
                footstepsAudioSource.clip = wanderingFootstepsClip;
                footstepsAudioSource.Play();
            }

            if (!growlingAudioSource.isPlaying || growlingAudioSource.clip != wanderingGrowlClip)
            {
                growlingAudioSource.clip = wanderingGrowlClip;
                growlingAudioSource.Play();
            }
            //
            dest = currentDest.position;
            ai.destination = dest;
            ai.speed = walkSpeed;
            aiAnim.ResetTrigger("sprint");
            aiAnim.ResetTrigger("idle");
            aiAnim.SetTrigger("walk");
            
            if (ai.remainingDistance <= ai.stoppingDistance)
            {
                //
                footstepsAudioSource.Stop();
                //growlingAudioSource.Stop();
                //
                SetState(EnemyState.Idle);
                StartCoroutine("stayIdle");
                
            }
            
        }
        else if (currentState == EnemyState.Idle)
        {
            aiAnim.ResetTrigger("sprint");
            aiAnim.ResetTrigger("walk");
            aiAnim.SetTrigger("idle");
            ai.speed = 0;
        }
    }

    void SetState(EnemyState newState)
    {
        currentState = newState;
    }

    IEnumerator stayIdle()
    {
        idleTime = Random.Range(minIdleTime, maxIdleTime);
        yield return new WaitForSeconds(idleTime);
        SetState(EnemyState.Patrolling);
        randNum = Random.Range(0, destinations.Count);
        currentDest = destinations[randNum];
    }

    IEnumerator chaseRoutine()
    {
        chaseTime = Random.Range(minChaseTime, maxChaseTime);
        yield return new WaitForSeconds(chaseTime);
        SetState(EnemyState.Patrolling);
        randNum = Random.Range(0, destinations.Count);
        currentDest = destinations[randNum];
    }

    IEnumerator deathRoutine()
    {
        yield return new WaitForSeconds(jumpscareTime);
        SceneManager.LoadScene(deathScene);
    }
}