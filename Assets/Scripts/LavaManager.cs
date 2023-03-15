/*using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Plateform : MonoBehaviour
{
    [SerializeField] GameObject[] plateformePrefabs;

    private float spawnZ, spawnY, spawnX = 0f; //spawnZ controle avant et arrière , SpawzY controle en haut en bas, SpawnX droite à gauche
    private float plateformeLength = 5f; // la taille du diamètre de la plateforme créé
    private int numPlatsOnScreen = 10; // Le nombre de plateforme sur l'écran
    private int lastPrefabIndex = 0;
    private float lifeSpan = 10f; // Le nombre de seconde où la plateforme va rester
    private Transform playerTransform;
    private List<GameObject> activePlateforms = new List<GameObject>();


    void Start()
    {
        //scoreManager = FindObjectOfType<ScoreManager>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        for (int i = 0; i < numPlatsOnScreen; i++)
        {
            if (i < 2)
                SpawnPlateform(0);
            else
                SpawnPlateform();
        }
    }

    void Update()
    {
        if (playerTransform.position.z > (spawnZ - numPlatsOnScreen * plateformeLength))
        {
            SpawnPlateform();
            DestoyPlateform();
        }
    }

    private void SpawnPlateform(int prefabIndex = -1)
    {
        GameObject go;
        if (prefabIndex == -1)
            go = Instantiate(plateformePrefabs[RandomPrefabIndex()]);
        else
            go = Instantiate(plateformePrefabs[prefabIndex]);

        go.transform.SetParent(transform);
        go.transform.position = new Vector3(spawnX, spawnY, spawnZ);

        // Randomize the position of the prefab
        Vector3 randomOffset = new Vector3(Random.Range(-4f, 4f), 0f, 0f);
        go.transform.position += randomOffset;

        // Add random rotation between 0 and 180 to each platform except the first three
        if (activePlateforms.Count >= 3)
        {
            Quaternion randomRotation = Quaternion.Euler(0f, Random.Range(0f, 180f), 0f);
            go.transform.rotation = randomRotation;
        }
        //casue of random rotation there could be a overlap if offset is an 0 for x, so adding one unit on top just in case
        spawnZ += plateformeLength + 1f;
        activePlateforms.Add(go);

        //spawnY += 1f;
        spawnX += Random.Range(0, 1f);
    }


    private void DestoyPlateform()
    {
        Destroy(activePlateforms[0], lifeSpan);
        activePlateforms.RemoveAt(0);
    }

    private int RandomPrefabIndex()
    {
        if (plateformePrefabs.Length <= 1)
            return 0;

        int randomIndex = lastPrefabIndex;
        while (randomIndex == lastPrefabIndex)
        {
            randomIndex = Random.Range(0, plateformePrefabs.Length);
        }

        lastPrefabIndex = randomIndex;
        return randomIndex;
    }
}
*/