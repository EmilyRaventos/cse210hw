using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("514 W Pumpkin dr.", "Rexburg", "Idaho", "USA", "83440");
        Lectures e1 = new Lectures(
            "Youth Fireside", "Youth, ages 12-17, come to hear a message from a visiting authority.", 
            "August 1, 2023", "7:00PM", "Emily Blunt", 300, a1);
        
        Address a2 = new Address("729 S Lily st.", "New Westminster", "British Columbia", "Canada", "V3L 3C1");
        Outdoors e2 = new Outdoors(
            "Family Reunion", "Extended family get together to visit, spend time together, and eat.", 
            "September 11, 2023", "12:00PM", "Sunny", a2);

        Address a3 = new Address("288 Laurel Ave.", "Morton Grove", "Illinois", "USA",  "60053");
        Receptions e3 = new Receptions(
            "Wedding Reception", "Friends and family get together to celebrate the marriage of John and Jane Doe.", 
            "July 21, 2023", "6:00PM", "myemail@gmail.com", a3);

        e1.DisplayAllDescriptions();
        e2.DisplayAllDescriptions();
        e3.DisplayAllDescriptions();

    }
}