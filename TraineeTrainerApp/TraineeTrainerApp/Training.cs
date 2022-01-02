using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeTrainerApp
{
    class Training
    {
		public string TrainingName { get; set; }
		public Course Course { get; set; }
		public Trainer Trainer { get; set; }
		private List<Trainee> trainees = new List<Trainee>();

		public void AddTrainee(Trainee trainee)
		{
			this.trainees.Add(trainee);
		}

		public List<Trainee> GetTrainees()
		{
			return this.trainees;
		}
	}
}
