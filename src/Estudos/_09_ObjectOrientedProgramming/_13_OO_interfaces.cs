using System;

public class InterfacesApp
{
    public static void Main(string[] args)
    {
        GamesEntity[] entities = new GamesEntity[5];
        entities[0] = new Player("Thiago", 100, 10);
        entities[1] = new Enemy("Bat", 10, 2);
        entities[2] = new Enemy("Vampire", 30, 15);
        entities[3] = new Enemy("Mummy", 50, 5);
        entities[4] = new Enemy("Werewolf", 35, 10);

        Random random = new Random();
        int turn = 0;
        Player player = (Player) entities[0];
        int AliveEnemys = entities.Length - 1;
        while(player.IsAlive && AliveEnemys > 0)
        {
            turn++;
            Console.WriteLine("".PadLeft(100, '-'));
            Console.WriteLine($"Turn: {turn}");
            AliveEnemys = entities.Length - 1;
            for(int i = 1; i < entities.Length; i++)
            {
                Enemy enemy = (Enemy) entities[i];
                if (!enemy.IsAlive)
                {
                    AliveEnemys--;
                }
                else
                {
                    enemy.Log();
                    enemy.TakeDamage(random.Next(0, player.Damage + 1));
                    if (enemy.IsAlive)
                    {
                        player.Log();
                        player.TakeDamage(random.Next(0, enemy.Damage + 1));
                        if (!player.IsAlive)
                        {
                            break;
                        }
                    }
                }
            }
        }
        Console.WriteLine("============================================ Fim de jogo ============================================");
        Console.WriteLine($"Games turn: {turn}");
        if (player.IsAlive)
        {
            Console.WriteLine($"Player: Won!");
            for(int i = 0; i < entities.Length; i++)
            {
                entities[i].Log();
            }

        }
        else
        {
            Console.WriteLine($"Player: Lost!");
            for(int i = 0; i < entities.Length; i++)
            {
                entities[i].Log();
            }
        }
    }
}

interface ILogger
{
    void Log();
}

interface IDamegeable
{
    void TakeDamage(int vlaue);
}

public class GamesEntity : ILogger, IDamegeable
{
    public int Hp { get; set; }
    public int Damage { get; set; }
    public bool IsAlive { get => Hp > 0;}

    public GamesEntity(int hp, int damage)
    {
        Hp = hp;
        Damage = damage;
    }

    public virtual void TakeDamage(int damage)
    {
        Hp -= damage;

        if (Hp < 0)
        {
          Hp = 0;
        }
    }

    public virtual void Log()
    {
        Console.Write($"[HP:{Hp}]");
        if (!IsAlive)
        {
            Console.WriteLine($"[Dead]");
        }
        else
        {
            Console.WriteLine($"[Alive]");
        }
    }
}

public class Player : GamesEntity
{
    public string?  Name { get; set; }

    public Player(string? name, int hp, int damage):base(hp, damage)
    {
        Name = name;
    }

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
        Console.WriteLine($"[Combat] Player: {Name}; Took [{damage}]; HP [{Hp}]");
        Log();
    }

    public override void Log()
    {
        Console.Write($"Player: {Name} ");
        base.Log();
    }
}


public class Enemy : GamesEntity
{
    public string? Type { get; set; }

    public Enemy(string? type, int hp, int damage):base(hp, damage)
    {
        Type = type;
    }

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
        Console.WriteLine($"[Combat] Enemy: {Type}; Took [{damage}]; HP [{Hp}]");
        Log();
    }

    public override void Log()
    {
        Console.Write($"Enemy: {Type} ");
        base.Log();
    }
}