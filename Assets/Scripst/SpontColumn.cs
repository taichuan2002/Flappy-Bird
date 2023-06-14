using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpontColumn : MonoBehaviour
{
    [SerializeField] private GameObject column;
    public float maxTime;
    private float time;

    private void Start()
    {
        time = maxTime;
    }
    void Update()
    {
        spontColumn();
    }
    private void spontColumn()
    {
        if (time > maxTime)
        {
            float random = Random.Range(0.5f, 6);
            GameObject columns = Instantiate(column, new Vector3(transform.position.x,
                transform.position.y + random, 0), Quaternion.identity);
            Destroy(columns, 8f);
            time = 0;
        }
        time += Time.deltaTime;
    }
}
