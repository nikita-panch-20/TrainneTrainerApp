using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeTrainerApp
{
    class Trainee
    {
        public string TraineeName { get; set; }
        public Trainer Trainer { get; set; }
        public Training Training { get; set; }
    }
}
