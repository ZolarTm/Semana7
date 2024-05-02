using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
   
    
        [SerializeField] private GameObject bulletPrefab;
        private PlayerMovement playerMovement;
    float shoottimer;

        private void Awake()
        {
            playerMovement = GetComponent<PlayerMovement>();
        }

        void Update()
        {
            Shoot();
        }

        void Shoot()
        {
         shoottimer += Time.deltaTime;     
            if (shoottimer >= 0.5f)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                GameObject obj = Instantiate(bulletPrefab);
                obj.transform.position = transform.position;
                obj.GetComponent<BulletMovement>().SetDirection(playerMovement.Direction.normalized);
                shoottimer = 0;
                }
            }
            
        }
    

}
