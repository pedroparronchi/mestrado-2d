using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increaseAndDecrease : MonoBehaviour
{
    private GameObject imageHeart;
    private float drecrease = 0.5f;
    private float increase = 1.0f;
    private string gameObjectName = "ImageHeart";

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        imageHeart = GameObject.Find(gameObjectName);

        if (imageHeart == null) {
            throw new System.Exception("Não encontrado o gameobject: " + gameObjectName);
        }


        if(imageHeart.transform.localScale.x <= 0.6)
        {
            Debug.Log("aumentando");
            this.Increase(imageHeart);
        } else
        {
            Debug.Log("diminuindo");
            this.Decrease(imageHeart);
        }

    }

    private void Increase(GameObject imageHeart)
    {

        imageHeart.transform.localScale = new Vector3(
            imageHeart.transform.localScale.x + increase * (Time.deltaTime + 0.5f),
            imageHeart.transform.localScale.y + increase * (Time.deltaTime + 0.5f),
            imageHeart.transform.localScale.z + increase * (Time.deltaTime + 0.5f)
        );
        Debug.Log(imageHeart.transform.localScale);

    }

    private void Decrease(GameObject imageHeart)
    {

        imageHeart.transform.localScale = new Vector3(
            imageHeart.transform.localScale.x - (drecrease * Time.deltaTime),
            imageHeart.transform.localScale.y - (drecrease * Time.deltaTime),
            imageHeart.transform.localScale.z - (drecrease * Time.deltaTime)
        );
        Debug.Log(imageHeart.transform.localScale);
    }
}
