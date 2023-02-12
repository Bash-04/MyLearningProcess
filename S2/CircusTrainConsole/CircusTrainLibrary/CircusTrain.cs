namespace CircusTrainLibrary
{
    public class CircusTrain
    {
        private List<Wagon> Wagons;
        private List<Animal> Animals;

        public CircusTrain()
        {
            Wagons = new List<Wagon>();
            Animals = new List<Animal>();
        }

        public string TryCreateNewAnimal(Size size, Type type)
        {
            Animal animal;
            if (AnimalMayBeCreated(size, type))
            {
                animal = new Animal(size, type);
                Animals.Add(animal);
            }
            else
            {
                return "Don't forget filling in a size AND a type for the animal";
            }
            return "Animal has succesfully been created";
        }

        private bool AnimalMayBeCreated(Size size, Type type)
        {
            if (size != Size.small && size != Size.small && size != Size.small || type != Type.Herbivor && type != Type.Carnivor)
            {
                return false;
            }
            return true;
        }
    }
}
