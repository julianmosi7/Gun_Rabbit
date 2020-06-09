namespace XUnitDemo
{
  public class Rabbit
  {
    private bool dodging;
    private bool dead;

    public void Dodge() => dodging = true;
    public void Hit() => dead = true;
    public void Miss() => dodging = false;
    public bool IsDodging() => dodging;
    public bool IsDead() => dead;
  }
}
