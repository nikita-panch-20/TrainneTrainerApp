using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeTrainerApp
{
    class Program
    {
		static void Main(string[] args)
		{
			//1. Create topics
			Topic topic1 = new Topic();
			topic1.TopicName = "Tables";
			Topic topic2 = new Topic();
			topic2.TopicName = "P tags";
			Topic topic3 = new Topic();
			topic3.TopicName = "for loop in JS";
			Topic topic4 = new Topic();
			topic4.TopicName = "Event binding";
			Topic topic5 = new Topic();
			topic5.TopicName = "Loopings in C#";
			Topic topic6 = new Topic();
			topic6.TopicName = "Arrays in C#";

			//2. Create units
			Unit unit1 = new Unit() { UnitName = "HTML basic" };
			Unit unit2 = new Unit() { UnitName = "HTML Adv" };
			Unit unit3 = new Unit() { UnitName = "JS Basic" };
			Unit unit4 = new Unit() { UnitName = "C# Basic" };

			//3. Add topics to unit
			unit1.AddTopic(topic2);
			unit2.AddTopic(topic1);
			unit3.AddTopic(topic3);
			unit3.AddTopic(topic4);
			unit4.AddTopic(topic5);
			unit4.AddTopic(topic6);

			//4. Create modules
			Module module1 = new Module() { ModuleName = "HTML Fund" };
			Module module2 = new Module() { ModuleName = "JS Fund" };
			Module module3 = new Module() { ModuleName = "C# Fund" };

			//5. Add units to module
			module1.AddUnit(unit1);
			module1.AddUnit(unit2);
			module2.AddUnit(unit3);
			module3.AddUnit(unit4);

			//6. Create courses
			Course course1 = new Course() { CourseName = "C# FIT" };

			//7. Add modules to course
			course1.AddModule(module1);
			course1.AddModule(module2);
			course1.AddModule(module3);

			//8. Create Technology
			Technology technology = new Technology() { TechnologyName = "C#" };

			//9. Add technology to course
			course1.Technology = technology;

			//10. Add courses to technology
			technology.AddCourse(course1);

			//11. Creating trainig
			Training training = new Training() { TrainingName = "FIT" };

			//12. Add course to trainings
			training.Course = course1;

			//13. Add Training to course
			course1.AddTraining(training);

			//14. Create trainer
			Trainer trainer = new Trainer() { TrainerName = "Shashi" };

			//15. Add training to trainer
			trainer.Training = training;

			//16. Add trainer to training
			training.Trainer = trainer;

			//17. Create trainees
			Trainee trainee1 = new Trainee() { TraineeName = "Shiva" };
			Trainee trainee2 = new Trainee() { TraineeName = "Shankar" };
			Trainee trainee3 = new Trainee() { TraineeName = "Suman" };
			Trainee trainee4 = new Trainee() { TraineeName = "Sham" };
			Trainee trainee5 = new Trainee() { TraineeName = "Ravi" };

			//18. Add trainee to training
			training.AddTrainee(trainee1);
			training.AddTrainee(trainee2);
			training.AddTrainee(trainee3);
			training.AddTrainee(trainee4);
			training.AddTrainee(trainee5);

			//19. Add training to trainee
			trainee1.Training = training;
			trainee2.Training = training;
			trainee3.Training = training;
			trainee4.Training = training;
			trainee5.Training = training;

			//20. Add trainee to trainer
			trainer.AddTrainee(trainee1);
			trainer.AddTrainee(trainee2);
			trainer.AddTrainee(trainee3);
			trainer.AddTrainee(trainee4);
			trainer.AddTrainee(trainee5);

			//21. Add trainer to trainee
			trainee1.Trainer = trainer;
			trainee2.Trainer = trainer;
			trainee3.Trainer = trainer;
			trainee4.Trainer = trainer;
			trainee5.Trainer = trainer;

			//22. Display Training Info
			DisplayTrainingInfo(training);
		}

		private static void DisplayTrainingInfo(Training training)
		{
			Console.WriteLine("Training Info");
			DrawLine();
			Console.WriteLine($"Training Name : {training.TrainingName}");
			Console.WriteLine($"Trainer Name : {training.Trainer.TrainerName}");
			Console.WriteLine("Trainees Name :");
			foreach (var trainee in training.GetTrainees())
			{
				Console.WriteLine(trainee.TraineeName);
			}
			DrawLine();
			Console.WriteLine("Course Details");
			DrawLine();
			Console.WriteLine($"Technology : {training.Course.Technology.TechnologyName}");
			Console.WriteLine($"Course : {training.Course.CourseName}");
			DrawLine();
			Console.WriteLine("Module Details");
			foreach (var module in training.Course.GetModules())
			{
				Console.WriteLine(module.ModuleName);
				foreach (var unit in module.GetUnits())
				{
					Console.WriteLine("\t" + unit.UnitName);
					foreach (var topic in unit.GetTopics())
					{
						Console.WriteLine("\t\t" + topic.TopicName);
					}
				}
				DrawLine();
			}
			DrawLine();
		}


		private static void DrawLine()
		{
			Console.WriteLine();
			for (int i = 0; i < 45; i++)
			{
				Console.Write("-");
			}
			Console.WriteLine();
		}
	}
}
