
class Program {
    static List<Task2.Box> GenerateRandomBoxes(int count) {

    Random random = new Random();
    List<Task2.Box> boxes = new List<Task2.Box>();

    for (int i = 0; i < count; i++) {
        int length = random.Next(1, 11);
        int width = random.Next(1, 11);
        int height = random.Next(1, 11);
        boxes.Add(new Task2.Box(length, width, height));
    }

    return boxes;
}


static List<Task2.Box> FindTallestStack(List<Task2.Box> boxes) {

    boxes.Sort((a, b) => a.Height.CompareTo(b.Height));
    List<Task2.Box> stack = new List<Task2.Box>();
    int maxHeight = 0;

    for (int i = 0; i < boxes.Count; i++) {
        List<Task2.Box> currentStack = new List<Task2.Box>();
        int currentHeight = 0;

        for (int j = i; j < boxes.Count; j++) {
            if (CanStack(boxes[i], boxes[j])) {
                currentStack.Add(boxes[j]);
                currentHeight += boxes[j].Height;
            }
        }

        if (currentHeight > maxHeight) {
            maxHeight = currentHeight;
            stack = currentStack;
        }
    }

    return stack;
}

static List<Task2.Box> MinimizePiles(List<Task2.Box> boxes) {
    boxes.Sort((a, b) => a.Height.CompareTo(b.Height));
    List<Task2.Box> result = new List<Task2.Box>();

    while (boxes.Count > 0) {
        List<Task2.Box> currentPile = new List<Task2.Box>();
        currentPile.Add(boxes[0]);
        int currentHeight = boxes[0].Height;
        boxes.RemoveAt(0);

        for (int i = boxes.Count - 1; i >= 0; i--) {
            if (CanStack(currentPile[0], boxes[i])) {
                currentPile.Add(boxes[i]);
                currentHeight += boxes[i].Height;
                boxes.RemoveAt(i);
            }
        }

        result.AddRange(currentPile);
    }

    return result;
}

static bool CanStack(Task2.Box bottom, Task2.Box top) {

    return top.Length <= bottom.Length && top.Width <= bottom.Width;

}

static void PrintBoxes(List<Task2.Box> boxes) {

    foreach (var box in boxes) {
        Console.WriteLine($"Length: {box.Length}, Width: {box.Width}, Height: {box.Height}");
    }
}

    static void Main(string[] args) {
        List<Task2.Box> boxes = GenerateRandomBoxes(10);

        Console.WriteLine("Prvotna lista kutija:");
        PrintBoxes(boxes);

        List<Task2.Box> tallestStack = FindTallestStack(boxes);
        List<Task2.Box> minimizedPiles = MinimizePiles(boxes);

        Console.WriteLine("Najviša hrpa:");
        PrintBoxes(tallestStack);

        Console.WriteLine("\nMinimalni broj hrpa:");
        PrintBoxes(minimizedPiles);
    }

}