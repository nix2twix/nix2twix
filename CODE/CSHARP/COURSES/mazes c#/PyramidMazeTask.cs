namespace Mazes
{
	public static class PyramidMazeTask
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
			int rightleftCount = width - 1;
			do
			{
				rightleftCount = rightleftCount - 2;
				MoveRight(robot, rightleftCount);
				MoveUp(robot, 2);
				rightleftCount = rightleftCount - 2;
				MoveLeft(robot, rightleftCount);
				if (robot.Finished != true) MoveUp(robot, 2);
			} while (robot.Finished != true);
		}
	}
}