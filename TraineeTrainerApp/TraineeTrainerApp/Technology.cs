using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeTrainerApp
{
    class Technology
    {
		public string TechnologyName { get; set; }
		private List<Course> courses = new List<Course>();

		public void AddCourse(Course course)
		{
			this.courses.Add(course);
		}

		public List<Course> GetCourse()
		{
			return this.courses;
		}
	}
}
