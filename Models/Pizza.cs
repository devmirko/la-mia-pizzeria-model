namespace la_mia_pizzeria_razor_layout.Models
{
    public class Pizza
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public Pizza()
        {

        }

        public Pizza(string name, string description, string image)
        {
            this.Name = Name;
            this.Description = description;
            this.Image = image;
        }
    }
}
