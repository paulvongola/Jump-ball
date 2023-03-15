using UnityEngine;
public class Plateform : MonoBehaviour
{
    [SerializeField] GameObject[] plateformePrefabs;

    [SerializeField] private int nbPlateform; // Représente le nb de plateformes
    [SerializeField] private float xmin = 2f; //Xmin c'est pour la marge gauche
    [SerializeField] private float xmax = -2f; //Xmax c'est pour la marge droite
    [SerializeField] private float zoffset = 0f;
    [SerializeField] private float yoffset = 0f;

    private float z_plateformInc = 2.5f + 0.2f; // c'est la taille de la plateforme pour éviter le chauvement






    void Start()
    {
        // tant que i est égal zéro est que i est inférieur au nb de plateformes on continue

        // Instantiate a number of platforms equal to total_number, starting from the second one
        for (int i = 1; i < nbPlateform; i++)
        {
            //randomizing x_offset of the platform
            float x_offset = Random.Range(xmin, xmax);
            //Instantiate the prefab
            Instantiate(plateformePrefabs[Random.Range(0, 2)], new Vector3(x_offset, yoffset, zoffset + z_plateformInc), Quaternion.identity);
            // update the z_offset
            zoffset += z_plateformInc;
        }

    }




}
