using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Plateform : MonoBehaviour
{
    [SerializeField] GameObject[] plateformePrefabs;

    [SerializeField] private int nbPlateform = 100; // Représente le nb de plateformes
    [SerializeField] private float xmin = -3f; //Xmin c'est pour la marge gauche
    [SerializeField] private float xmax = 3f; //Xmax c'est pour la marge droite
    [SerializeField] private float zoffset = 0f;
   
     [SerializeField] private float z_plateformInc = 10f ; // c'est la taille de la plateforme pour éviter le chauvement



   


    void Start()
    {
      // tant que i est égal zéro est que i est inférieur au nb de plateformes on continue

        for (int i = 0; i < nbPlateform; i++)
        {
            //x offset représente la marge entre les plateformes
            float x_offset = Random.Range(xmin, xmax);
            // ici on instancie une plateforme aléatoirement dans une position donner
            Instantiate(plateformePrefabs[Random.Range(0, plateformePrefabs.Length)], new Vector3(x_offset, 0, zoffset + z_plateformInc + 6f), Quaternion.identity); ;
            zoffset += z_plateformInc;


        }
    }

   

  
}