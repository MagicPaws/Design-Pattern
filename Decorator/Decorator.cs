namespace Decorator;

public abstract class Gun
{
    public float atk;
    public abstract void Shoot();    
}

public class Ak : Gun
{
    public Ak()
    {
        atk = 100;
    }
    public override void Shoot()
    {
        Console.WriteLine("Ak Shoot!");
        Console.WriteLine("伤害为" + atk);
    }
}
public class M4 : Gun
{
    public M4()
    {
        atk = 98;
    }
    public override void Shoot()
    {
        Console.WriteLine("M4 Shoot!");
        Console.WriteLine("伤害为" + atk);
    }
}

public abstract class Decorator
{
    public abstract void SetComponet(Gun gun);
}

public class Buff : Decorator
{
    public override void SetComponet(Gun gun)
    {
        gun.atk *= 2;
    }
}