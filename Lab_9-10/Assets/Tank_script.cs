using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank_script : MonoBehaviour {

	public float moveSpeed = 5f;
	public float rotateSpeed = 50f;
    public float turretRotateSpeed = 30f;
    public float barrelRotateSpeed = 20f;

    public GameObject bombPrefab;
    public float areaWidth = 4f;
    public float areaLength = 6f;
    public int bombCount = 5;
    public float spawnHeight = 10f;

    public Transform bash;    
    public Transform stv;	

    AudioSource moveAudio;

    // Use this for initialization
    void Start () {
        moveAudio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        // Движение корпуса вперёд/назад
        float move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, 0, move);

        if (Mathf.Abs(move) > 0f)
        {
            if (!moveAudio.isPlaying)
                moveAudio.Play();
        }
        else
        {
            if (moveAudio.isPlaying)
                moveAudio.Stop();
        }

        // Поворот корпуса влево/вправо
        float turn = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        transform.Rotate(0, turn, 0);

        // Вращение башни по мыши (влево/вправо)
        float mouseX = Input.GetAxis("Mouse X") * turretRotateSpeed * Time.deltaTime;
        bash.Rotate(0, -mouseX, 0);

        // Подъём/опускание ствола по мыши (вверх/вниз)
        float mouseY = Input.GetAxis("Mouse Y") * barrelRotateSpeed * Time.deltaTime;
        stv.Rotate(mouseY, 0, 0);

        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(SpawnBombsGradually());
        }
    }

    IEnumerator SpawnBombsGradually()
    {
        Vector3 tankPos = transform.position;
        Vector3 center = tankPos + transform.forward * (areaLength / 2f);

        for (int i = 0; i < bombCount; i++)
        {
            float offsetX = Random.Range(-areaWidth / 2f, areaWidth / 2f);
            float offsetZ = Random.Range(-areaLength / 2f, areaLength / 2f);
            Vector3 spawnPos = new Vector3(center.x + offsetX, spawnHeight, center.z + offsetZ);

            Instantiate(bombPrefab, spawnPos, Quaternion.identity);
            yield return new WaitForSeconds(0.2f); // задержка между бомбами
        }
    }
}
