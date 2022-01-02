using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TraineeTrainerApp
{
    class Unit
    {
		public string UnitName { get; set; }
		//public List<Topic> Topics { get; set; }

		private List<Topic> topics = new List<Topic>();

		public void AddTopic(Topic topic)
		{
			this.topics.Add(topic);
		}

		public List<Topic> GetTopics()
		{
			return this.topics;
		}

	}
}
