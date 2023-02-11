using BJJ_Trainer_Assist.Models;

namespace BJJ_Trainer_Assist.Service
{
    public class PairMatchingService
    {
        private readonly List<Fighter> _fighters;
        private Fighter? _fighter1 = null;
        private Fighter? _fighter2 = null;

        public PairMatchingService(List<Fighter> fighters)
        {
            _fighters = fighters;
        }

        public Tuple<Fighter, Fighter> FindMatchingPair()
        {
            double closestDifference = double.MaxValue;

            for (int i = 0; i < _fighters.Count; i++)
            {
                for (int j = i + 1; j < _fighters.Count; j++)
                {
                    double currentDifference = Math.Abs(_fighters[i].Weight - _fighters[j].Weight) + 
                                               Math.Abs(_fighters[i].BMI - _fighters[j].BMI) + 
                                               Math.Abs(_fighters[i].BeltRank.Stripe - _fighters[j].BeltRank.Stripe) + 
                                               Math.Abs(_fighters[i].MaxWorkoutDuration - _fighters[j].MaxWorkoutDuration);
                    if (currentDifference < closestDifference)
                    {
                        closestDifference = currentDifference;
                        _fighter1 = _fighters[i];
                        _fighter2 = _fighters[j];
                    }
                }
            }

            if (_fighter1 == null || _fighter2 == null)
            {
                throw new ApplicationException("There is a problem in the pairing process, one of the 2 fighters is NULL");
            }

            return new Tuple<Fighter, Fighter>(_fighter1, _fighter2);
        }
    }
}
