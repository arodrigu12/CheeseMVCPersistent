namespace CheeseMVC.Models
{
    public class Cheese
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Navigation property corresponding to a particular CategoryID object
        public CheeseCategory Category { get; set; }
        
        //Foreign key propperty
        public int CategoryID { get; set; }
    }
}
