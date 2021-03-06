using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LINQExample : MonoBehaviour
{
    //language
    //Integrated
    //Query

    public void OnEnable()
    {
        var names = new[] { "Gary", "Chloe", "Claire", "Rebecca", "EZ", "Ben", "Kevin", "Giselle" };

        //Query Syntax
        var namesWithAQuery = from name in names
                              where name.Contains("C")
                              select name;

        //Method Syntax
        var namesWithAMethod = names.Where(name=>name.Contains('C'));

        foreach (var name in namesWithAQuery)
        {
            Debug.Log($"QUERY:{name}");
        }
        foreach(var name in namesWithAMethod)
        {
            Debug.Log($"METHOD:{name}");
        }

        //Method syntax has MORE operators and methods, the compiler converts query syntax anyway...
        //It doesn't really matter which one you use,but keep this in mind..

        var enemies = new List<Enemy>()
        {
            new Enemy(){Name = "Gary",HP=9000},
            new Enemy(){Name = "Chris",HP=0},
            new Enemy(){Name = "Ben",HP=90},
            new Enemy(){Name = "Claire",HP=9000},
            new Enemy(){Name = "Chloe",HP=2},
            new Enemy(){Name = "Rebecca",HP=10},
            new Enemy(){Name = "Giselle",HP=34},
            new Enemy(){Name = "Kevin",HP=45},
            new Enemy(){Name = "EZ",HP=50},
        };

        //Filitering operators:filter a sequence based on some argument or criteria
        //Lambda... => "goes to"
        var deadEnemies = enemies.Where(enemy => enemy.HP <= 0);

        //we could instead...
        var deadEnemiesBORING = new List<Enemy>();

        foreach(var enemy in deadEnemies)
        {
            if(enemy.HP <= 0)
            {
                deadEnemiesBORING.Add(enemy);
            }

        }
        foreach(var enemy in deadEnemies)
        {
            Debug.Log($"Dead enemy:{enemy.Name}");
        }
    }


}
public class Enemy
{
    public string Name;
    public int HP;
}
