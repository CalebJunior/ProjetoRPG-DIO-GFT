namespace PROJETO_RPG_DIO.src.entities
{
    public class Ninja:Hero
    {
        public Ninja(string name){
            this.name = name;
            maxHp = 200;
            maxMp = 120;
            currentHp= maxHp;
            currentMp = maxMp;
        }

        public int AttackBasic(){
            return 160;
        }

        public int ShadowKiller(){
            if(currentMp>=100){
                currentMp-=60;
                Console.WriteLine("ShadowKiller executa com sucesso");
                return 300;
            }
            else{
                Console.WriteLine("Infelizmente você não conseguiu executar pois não tem mana");
                return 0;
            }


        }

    }
}