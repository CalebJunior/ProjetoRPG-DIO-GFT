namespace PROJETO_RPG_DIO.src.entities
{
    public class Wizard:Hero
    {
        public Wizard(string name){
            this.name = name;
            maxHp = 100;
            maxMp = 600;
            currentHp= maxHp;
            currentMp = maxMp;
        }

        public int AttackBasic(){
            return 40;
        }

        public int FireBall(){
            if(currentMp>=100){
                currentMp-=100;
                Console.WriteLine("FireBall executa com sucesso");
                return 400;
            }
            else{
                Console.WriteLine("Infelizmente você não conseguiu executar pois não tem mana");
                return 0;
            }

        }

        
    }
}