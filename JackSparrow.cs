namespace mis321_pa2_roguffey
{
    public class JackSparrow : Character
    {
        public JackSparrow()
        {
            SetAttackBehavior(new Distraction());
        }
    }
}