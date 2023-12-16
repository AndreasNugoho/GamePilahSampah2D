using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakPindah : MonoBehaviour
{

    // float speed = 3f; // kecepatan awal dari sprite
    // public Sprite[] sprites; // menyimpan nilai array tunggal yang nantinya digunakan untuk menyimpan gambar berupa sprite


    // // Use this for initialization, // hanya sekali dijalankan ketika load
    // void Start()
    // {
    //     int index = Random.Range(0, sprites.Length); //Memberi nilai Acak dengan batasan maksimal sejumlah array Sprite yang dimasukkan
    //     gameObject.GetComponent<SpriteRenderer>().sprite = sprites[index];

    // }

    // // Update is called once per frame
    // void Update()
    // {

    //     // float move = (speed * Time.deltaTime * -1f) + transform.position.x; //menghitung pergerakan kekiri berikutnya pada suatu object berdasarkan sumbu X
    //     // transform.position = new Vector3(move, transform.position.y); // implement pergerakan horizontal pada gameobject

    // }
    private Vector3 screenPoint;
    private Vector3 offset;
    private float firstY;

    void OnMouseDown()
    {
        firstY = transform.position.y;
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }

    private void OnMouseUp()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }
}
