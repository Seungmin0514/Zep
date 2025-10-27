using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CameraMove : MonoBehaviour
{
    public Transform player;
    public Tilemap mapTilemap;

    private float minX, minY, maxX, maxY;

    void Start()
    {
        float camHalfHeight = Camera.main.orthographicSize;
        float camHalfWidth = camHalfHeight * Camera.main.aspect;

        Bounds mapBounds = mapTilemap.localBounds;

        minX = mapBounds.min.x + camHalfWidth;
        maxX = mapBounds.max.x - camHalfWidth;
        minY = mapBounds.min.y + camHalfHeight;
        maxY = mapBounds.max.y - camHalfHeight;
    
}

    // Update is called once per frame
    void Update()
    {
        if (player == null) return;

        float clampedX = Mathf.Clamp(player.position.x, minX, maxX);
        float clampedY = Mathf.Clamp(player.position.y, minY, maxY);

        transform.position = new Vector3(clampedX, clampedY, transform.position.z);
    }
}
