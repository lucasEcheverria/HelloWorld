using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnemyPlayer;

public class helloWorld : MonoBehaviour
{
    Enemy enemy;
    Player player;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world");

        player = new player("MainCharacter");
        enemy = new enemy("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("La salud del jugador es de: " + player);
        Debug.Log("El jugador ha eliminado: " + player.getKills());

    }
}
