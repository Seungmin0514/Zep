using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    
    // Start is called before the first frame update
    public float highPosY = 1f;
    public float lowPosY = -1f;

    public float holeSizeMin = 1f;
    public float holeSizeMax = 3f;

    public Transform topObject;
    public Transform bottomObject;

    public float widthPadding = 4f;

    MiniGameManager gameManager;

    private void Start()
    {
        gameManager = MiniGameManager.Instance;
    }
    public Vector3 SetRandomPlace(Vector3 lastPosition,int obstaclCount)
    {
        float holeSize = Random.Range(holeSizeMin,holeSizeMax);
        float halfHoleSize = holeSize / 2;

        topObject.localPosition = new Vector3(0, halfHoleSize);
        bottomObject.localPosition = new Vector3(0,-halfHoleSize);

        Vector3 placePositon = lastPosition + new Vector3(widthPadding, 0);
        placePositon.y = Random.Range(lowPosY, highPosY);

        transform.position = placePositon;

        return placePositon;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Plane player = collision.GetComponent<Plane>();
        if(player != null)
        {
            gameManager.AddScore(1);
        }
    }
}
