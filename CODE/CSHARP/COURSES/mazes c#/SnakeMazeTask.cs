namespace Mazes
{
	public static class SnakeMazeTask
	{
		public static void MoveLeft(Robot robot, int stepCount)
		{
			for (int i = 0; i < stepCount; i++)
			{
				robot.MoveTo(Direction.Left);
			}
		}

		public static void MoveRight(Robot robot, int stepCount)
		{
			for (int i = 0; i < stepCount; i++)
			{
				robot.MoveTo(Direction.Right);
			}
		}

		public static void MoveUp(Robot robot, int stepCount)
		{
			for (int i = 0; i < stepCount; i++)
			{
				robot.MoveTo(Direction.Up);
			}
		}

		public static void MoveDown(Robot robot, int stepCount)
		{
			for (int i = 0; i < stepCount; i++)
			{
				robot.MoveTo(Direction.Down);
			}
		}

		public static void MoveOut(Robot robot, int width, int height)
		{
			do
			{
				MoveRight(robot, width - 3);
				MoveDown(robot, 2);
				MoveLeft(robot, width - 3);
				if (robot.Y != height - 2) MoveDown(robot, 2);
			} while (robot.Finished != true);
		}
	}
}