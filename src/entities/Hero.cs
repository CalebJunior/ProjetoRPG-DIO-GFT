namespace PROJETO_RPG_DIO.src.entities
{
    public abstract class Hero
    {
        public string name;

        protected int maxHp;

        protected int currentHp;


        protected int maxMp;

        protected int currentMp;

        public int StatusHealth(){
            return currentMp;
        }

        public void AllStatus(){
            Console.WriteLine($"Health:{currentHp}/{maxHp} Mana:{currentMp}/{maxMp} ");
        }

        public void Damage(){
            currentHp -= 60;
        }

    }
}