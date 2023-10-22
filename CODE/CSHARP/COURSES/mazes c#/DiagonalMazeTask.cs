namespace Mazes
{
	public static class DiagonalMazeTask
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
			int rightCount = ((width / 2 - height/2) / (height / 2 - 1));
			int downCount = ((height / 2 - width / 2) / (width / 2 - 1));
			do
			{
				if (rightCount > downCount)
				{
					MoveRight(robot, rightCount + 1);
					if (robot.Y != height - 2) MoveDown(robot, downCount + 1);
				}
				else
				{
					MoveDown(robot, downCount + 1);
					if (robot.X != width - 2) MoveRight(robot, rightCount + 1);
				}
			} while (robot.Finished != true);
		}
	}
}