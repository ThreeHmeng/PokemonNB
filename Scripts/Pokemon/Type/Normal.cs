using System.Collections;
using Pokemon.Species;

namespace Pokemon.Type
{
    public class Normal : Type
    {
        public Normal()
        {
            _typeName = "Normal";
            _superEffective = new ArrayList();
            //_superEffective.Add("Water");
            _effective = new ArrayList();
            _effective.Add("Electric");
            _effective.Add("Fire");
            _effective.Add("Flying");
            _effective.Add("Grass");
            _effective.Add("Normal");
            _effective.Add("Poison");
            _effective.Add("Water");
            _notVeryEffective = new ArrayList();
            _notVeryEffective.Add("Flying");
            _notVeryEffective.Add("Poison");
            _notVeryEffective.Add("Fire");
            _notVeryEffective.Add("Grass");
            _notEffective = new ArrayList();
        }
    }
}