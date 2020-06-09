namespace XUnitDemo
{
  public class Gun
  {
    private int ammo = 3;

    public void FireAt(Rabbit rabbit)
    {
      if (!HasAmmo()) return;
      if (rabbit.IsDodging()) rabbit.Miss();
      else rabbit.Hit();
      ammo--;
    }

    public void Recharge() => ammo = 3;
    public bool HasAmmo() => ammo > 0;
  }
}
