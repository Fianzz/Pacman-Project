using UnityEngine;

public class PowerPellet : Pellet
{
    public float duration = 8f;

    protected override void Eat()
    {
        // Ahmad Rajis Buwono,Mangku Limo Wanito,Tanpo Busono Sedoyo
        FindObjectOfType<GameManager>().PowerPelletEaten(this);
    }

}
