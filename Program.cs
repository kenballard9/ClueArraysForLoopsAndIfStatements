internal class Program
{
    static Random randomSuspect = new Random();

    static void Main(string[] args)
    {
        string[] suspects = { "Miss Scarlet", "Colonel Mustard", "Mrs. Peacock", "Mr. Green", "Professor Plum", "Mrs. White" };

        for (int i = 0; i < suspects.Length; i++)
        {
            Console.WriteLine("Suspect: " + suspects[i]);
        }

        int selectedSuspect = randomSuspect.Next(0, suspects.Length);

        string culprit;

        if (selectedSuspect == 0)
        {
            culprit = "Miss Scarlet";
        }
        else if (selectedSuspect == 1)
        {
            culprit = "Colonel Mustard";
        }
        else if (selectedSuspect == 2)
        {
            culprit = "Mrs. Peacock";
        }
        else if (selectedSuspect == 3)
        {
            culprit = "Colonel Mustard";
        }
        else if (selectedSuspect == 4)
        {
            culprit = "Mr. Green";
        }
        else if (selectedSuspect == 5)
        {
            culprit = "Professor Plum";
        }
        else if (selectedSuspect == 6)
        {
            culprit = "Mrs. White";
        }
        else
        {
            culprit = "Unknown";
        }


        Console.WriteLine();



        string[] possibleRooms = { "Kitchen", "Ballroom", "Conservatory", "Dining Room", "Billiard Room", "Library", "Lounge", "Hall", "Study" };

        for (int i = 0; i < possibleRooms.Length; i++)
        {
            Console.WriteLine("Possible Room: " + possibleRooms[i]);
        }

        Random randomRoom = new Random();

        string murderRoom;

        int selectedRoom = randomRoom.Next(0, possibleRooms.Length);

        if (selectedRoom == 0)
        {
            murderRoom = "Kitchen";
        }
        else if (selectedRoom == 1)
        {
            murderRoom = "Ballroom";
        }
        else if (selectedRoom == 2)
        {
            murderRoom = "Conservatory";
        }
        else if (selectedRoom == 3)
        {
            murderRoom = "Dining Room";
        }
        else if (selectedRoom == 4)
        {
            murderRoom = "Billiard Room";
        }
        else if (selectedRoom == 5)
        {
            murderRoom = "Library";
        }
        else if (selectedRoom == 6)
        {
            murderRoom = "Lounge";
        }
        else if (selectedRoom == 7)
        {
            murderRoom = "Hall";
        }
        else if (selectedRoom == 8)
        {
            murderRoom = "Study";
        }
        else
        {
            murderRoom = "Unknown";
        }


        Console.WriteLine();


        string[] weapons = { "Knife", "Revolver", "Rope", "Lead Pipe", "Wrench", "Candlestick" };

        for (int i = 0; i < weapons.Length; i++)
        {
            Console.WriteLine("Possible Weapon: " + weapons[i]);
        }

        Random randomWeapon = new Random();

        int selectedWeapon = randomWeapon.Next(0, weapons.Length);

        string murderWeapon;

        if (selectedWeapon == 0)
        {
            murderWeapon = "Knife";
        }
        else if (selectedWeapon == 1)
        {
            murderWeapon = "Revolver";
        }
        else if (selectedWeapon == 2)
        {
            murderWeapon = "Rope";
        }
        else if (selectedWeapon == 3)
        {
            murderWeapon = "Lead Pipe";
        }
        else if (selectedWeapon == 4)
        {
            murderWeapon = "Wrench";
        }
        else if (selectedWeapon == 5)
        {
            murderWeapon = "Candlestick";
        }
        else
        {
            murderWeapon = "Unknown";
        }

        Console.WriteLine();

        Console.WriteLine("It was " + culprit + " in the " + murderRoom + " with the " + murderWeapon + "!");
    }
}