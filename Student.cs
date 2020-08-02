using System;

namespace ConsoleApp1
{
	public class Student:People
	{
		int level = 1;
		public Student(string name, int age, int level):base(name,age)
		{
			this.level = level;
		}

		public void ShowInfo()
		{
			base.ShowPeopleInfo();
			Console.WriteLine("level:" + level);
		}

		override
		public void ShowPeopleInfo()
		{
			base.ShowPeopleInfo();
			Console.WriteLine("level:" + level);
		}

		public void ShowPeopleInfo(bool isS)
		{
			base.ShowPeopleInfo();
			if (isS)
			{
				Console.WriteLine("level:" + level);
			}
		}



	}

}

