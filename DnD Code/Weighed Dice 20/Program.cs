Random random = new Random();

/*
Dictionary<string, int> numberWeight=
    new Dictionary<string, int>();

numberWeight.Add("1", 10);
numberWeight.Add("2", 10);
numberWeight.Add("3", 10);
numberWeight.Add("4", 10);
numberWeight.Add("5", 10);
numberWeight.Add("6", 10);
numberWeight.Add("7", 10);
numberWeight.Add("8", 10);
numberWeight.Add("9", 10);
numberWeight.Add("10", 10);
numberWeight.Add("11", 10);
numberWeight.Add("12", 10);
numberWeight.Add("13", 10);
numberWeight.Add("14", 10);
numberWeight.Add("15", 10);
numberWeight.Add("16", 10);
numberWeight.Add("17", 10);
numberWeight.Add("18", 10);
numberWeight.Add("19", 10);
numberWeight.Add("20", 10);
*/


int[] diceNumbers = new int[100];

int roll = random.Next(diceNumbers.Length);

int rollNumber = diceNumbers[roll];

Console.WriteLine(rollNumber);