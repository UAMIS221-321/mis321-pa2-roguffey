namespace mis321_pa2_roguffey
{
    public class DavyJones : Character
    {
        public DavyJones()
        {
            SetAttackBehavior(new CannonFire());
        }
    }
}