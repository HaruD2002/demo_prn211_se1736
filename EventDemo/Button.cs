namespace EventDemo
{
    internal class Button
    {
        public Button(string name)
        {
            Name = name;
        }

        public string Name { get; set; }


        // create an event for a prop name button
        public delegate void btnHandler(string name); //create  a delegate for a void function
        public event btnHandler onClick; //create an event name on click
        internal void click()
        {
            if (onClick != null)
            { //check if btn have an onclick event or not
                onClick(Name);
            }
            else {

                Console.WriteLine("Button" + Name + "dont have an event");
            }
        }
    }
}