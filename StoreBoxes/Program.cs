using StoreBoxes;
using System.Text;

List<Box> boxes = new List<Box>();

string input = Console.ReadLine();

while (input != "end")
{
    string[] inputData = input.Split(' ');
    int serialNumber = int.Parse(inputData[0]);
    string itemName = inputData[1];
    int itemQuantity = int.Parse(inputData[2]);
    double itemPrice = double.Parse(inputData[3]);

    Item currentItem = new Item
    {
        Name = itemName,
        Price = itemPrice,
    };

    Box currentBox = new Box
    {
        SerialNumber = serialNumber,
        Item = currentItem,
        ItemQuantity = itemQuantity,
        PriceForBox = itemQuantity * itemPrice,
    };

    boxes.Add(currentBox);

    input = Console.ReadLine();
}

boxes = boxes.OrderByDescending(box => box.PriceForBox).ToList();

StringBuilder sb = new StringBuilder();

foreach (Box box in boxes)
{
    sb.AppendLine($"{box.SerialNumber}");
    sb.AppendLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
    sb.AppendLine($"-- ${box.PriceForBox:F2}");
}

Console.WriteLine(sb.ToString().Trim());