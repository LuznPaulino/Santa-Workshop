using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public int treeHealth;
    public SpriteRenderer treeImage;
    // Start is called before the first frame update
    public Tree()
    {
        treeHealth = 100;
        treeImage = null;
    }

    public Tree(int health, SpriteRenderer image)
    {
        treeHealth = health;
        treeImage = image;
    }
    
    
    public void treeHealthReduced()
    {
        treeHealth--;
    }

    public int currentTreeHealth()
    {
        return treeHealth;
    }

}
