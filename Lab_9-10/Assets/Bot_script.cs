using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot_script : MonoBehaviour
{

    float movespeed = 0.25f;      
    float rotspeedtank = 0.1f;    
    float rotspeedbash = 0.5f;    
    float speedcore = 1f;         

    public Transform bash;        
    public Transform stvol;       
    public GameObject core;       

    bool canshoot = true;         
    int life = 3;                 

    IEnumerator botshoot()
    {
        canshoot = false;

        // Снаряд появляется чуть выше ствола, по направлению вверх от ствола
        Vector3 spawnPos = stvol.position + stvol.forward * 2f;
        GameObject newcore = Instantiate(core, spawnPos, stvol.rotation);

        Rigidbody rb = newcore.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = stvol.forward * speedcore;
        }

        yield return new WaitForSeconds(3f);
        canshoot = true;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && bash != null && stvol != null && core != null)
        {
            Vector3 relativePos = other.transform.position - transform.position;
            float distance = relativePos.magnitude;

            // Поворот башни к игроку
            Quaternion targetRot = Quaternion.LookRotation(relativePos);
            bash.rotation = Quaternion.Slerp(bash.rotation, targetRot, Time.deltaTime * rotspeedbash);


            // Проверка попадания луча
            RaycastHit hit;
            if (Physics.Raycast(bash.position, bash.forward, out hit, 100f))
            {
                if (hit.transform.CompareTag("Player") && canshoot)
                {
                    StartCoroutine(botshoot());
                }
            }

            // Движение и поворот корпуса при сближении
            if (distance < 20f)
            {
                Quaternion tankRot = Quaternion.LookRotation(relativePos);
                transform.rotation = Quaternion.Slerp(transform.rotation, tankRot, Time.deltaTime * rotspeedtank);

                Vector3 moveTarget = Vector3.Lerp(transform.position, other.transform.position, Time.deltaTime * movespeed);
                transform.position = moveTarget;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "core")
        {
            life--;
            if (life < 1) Destroy(gameObject);
        }
    }



    void Start() { }

    void Update() { }
}
