class Program {

    //Unosi se broj redova i provjerava da li je pravilan broj unesen
    static void Main() {
        Console.Write("Unesite broj redova za božično dvrce: ");
        if (int.TryParse(Console.ReadLine(), out int rowCount) && rowCount > 0) {
            PrintChristmasTree(rowCount);
        } else {
            Console.WriteLine("Molim vas unesite pravilan broj redova.");
        }
    }

    //Ispisuje se božično drvce u ovisnosti sa brojem redova odabranim
    static void PrintChristmasTree(int rowCount) {
        int trunkHeight = Math.Max(1, rowCount / 3); 
        int treeWidth = rowCount + rowCount - 1;

        for (int row = 1; row <= rowCount; row++) {
            string spaces = new string(' ', rowCount - row);
            string stars = new string('*', row + row - 1);
            Console.WriteLine(spaces + stars);
        }

        for (int trunk = 0; trunk < trunkHeight; trunk++) {
            string trunkSpaces = new string(' ', rowCount - 1);
            string trunkStars = "*";
            Console.WriteLine(trunkSpaces + trunkStars);
        }
    }
}