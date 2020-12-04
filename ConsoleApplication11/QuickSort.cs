namespace MMDABrowser {
	public class QuickSort {
		private static int Partition(ref int[] arr, int low, int high)
		{
			int pivot = arr[high];
			int lowIndex = (low - 1);
			for (int i = low; i < high; i++)
			{
				if (arr[i] <= pivot)
				{
					lowIndex ++;
					int tmp = arr[lowIndex];
					arr[lowIndex] = arr[i];
					arr[i] = tmp;
				}
			}
			int tmp1 = arr[lowIndex + 1];
			arr[lowIndex + 1] = arr[high];
			arr[high] = tmp1;
			return lowIndex + 1;
		}

		public static void Sort(ref int[] arr, int low, int high)
		{
			if (low < high)
			{
				int pi = Partition(ref arr, low, high);

				Sort(ref arr, low, pi - 1);
				Sort(ref arr, pi + 1, high);
			}
		}
	}
}