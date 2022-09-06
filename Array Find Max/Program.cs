
int[] items = new int[7];
for(int i=0;i<items.Length;i++)
{
	Console.Write("Enter  Price Of Item: "+(i+1)+": ");
	items[i] = Convert.ToInt32(Console.ReadLine());
}

for(int i =0;i<items.Length;i++)
{
	Console.WriteLine( (i+1)+ " Item  Price: " + items[i]);
}

int greater, largeindex = 0;

greater = items[0];
for(int i=0;i<items.Length;i++)
{
	if (items[i]>greater)
	{
		greater = items[i];
		largeindex = i;
	}

}
Console.WriteLine("Large Number Is: " + greater) ;
Console.WriteLine("Large Index Is: " + largeindex);
