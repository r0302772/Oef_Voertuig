using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voertuig_Models
{
    public delegate void AutoHandler(Voertuig sender);

    public class Voertuig
    {
        public event AutoHandler AutoGestartEvent = null;
        public event AutoHandler AutoGestoptEvent = null;
        public event AutoHandler TankBijnaOpEvent = null;
        public event AutoHandler TankChangedEvent = null;
        public event AutoHandler TankOpEvent = null;

        private double _litersInTank;

        public double LitersInTank
        {
            get { return _litersInTank; }
            set { _litersInTank = value; }
        }

        private int _snelheid;

        public int Snelheid
        {
            get { return _snelheid; }
            set { _snelheid = value; }
        }

        public void VerminderAantalLiters()
        {
            LitersInTank -= 1;
        }

        public override string ToString()
        {
            return $"Dit voertuig heef {LitersInTank} en {Snelheid}";
        }
    }
}
