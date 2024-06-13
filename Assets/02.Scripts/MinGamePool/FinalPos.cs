using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPos : MonoBehaviour
{
    [SerializeField] private float _delayTime;
    [SerializeField] private float minPosX, maxPosX;
    [SerializeField] private float minPosY, maxPosY;

    private void Start()
    {
        StartCoroutine(PosDelay());
    }

    private IEnumerator PosDelay()
    {
        float x = 0;
        float y = 0;
        while (true)
        {
            x = Random.Range(minPosX, maxPosX);
            y = Random.Range(minPosY, maxPosY);
            transform.position = new Vector2(x, y);
            yield return new WaitForSeconds(_delayTime);
        }
    }
}
