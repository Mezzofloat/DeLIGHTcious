using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{
    [SerializeField] Food berry, cheese, cake;
    [SerializeField] Camera cam;
    [SerializeField] float lightModeSpeedMultiplier;

    Vector2 bounds;
    bool isInLightMode;

    void Awake() => bounds = new Vector2(cam.aspect * cam.orthographicSize + 1, cam.orthographicSize + 1);

    void Start() {
        StartCoroutine(nameof(SpawnBerry));
        StartCoroutine(nameof(SpawnCheese));
        StartCoroutine(nameof(SpawnCake));
    }

    IEnumerator SpawnBerry() {
        while(true) {
            yield return new WaitForSeconds(berry.waitTime / (isInLightMode ? lightModeSpeedMultiplier : 1));
            var ber = PlaceFoodInWorld(berry);
        }
    }

    IEnumerator SpawnCheese() {
        while(true) {
            yield return new WaitForSeconds(cheese.waitTime / (isInLightMode ? lightModeSpeedMultiplier : 1));
            var che = PlaceFoodInWorld(cheese);
        }
    }

    IEnumerator SpawnCake() {
        while(true) {
            yield return new WaitForSeconds(cake.waitTime / (isInLightMode ? lightModeSpeedMultiplier : 1));
            var cak = PlaceFoodInWorld(cake);
        }
    }
    
    Food PlaceFoodInWorld(Food f)
    {
        return Instantiate(f,
                    new Vector3(Random.Range(-bounds.x + cam.transform.position.x, bounds.x + cam.transform.position.x), Random.Range(-bounds.y + cam.transform.position.y, bounds.y + cam.transform.position.y), 0),
                    Quaternion.identity);
    }
}
