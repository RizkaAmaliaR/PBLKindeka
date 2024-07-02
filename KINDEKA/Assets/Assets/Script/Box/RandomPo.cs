using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPo : MonoBehaviour
{
    public BoxCollider gridArea;

    private void Start()
    {
        // Mengatur posisi acak pada awal permainan
        //transform.position = new Vector3(Random.Range(-minRange, maxRange), vector3Y, Random.Range(-minRange, maxRange));
        RandomizePosition();
    }

    private void RandomizePosition()
    {
        Bounds bounds = this.gridArea.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);
        float z = Random.Range(bounds.min.z, bounds.max.z);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), Mathf.Round(z));
    }
}
