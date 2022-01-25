using System;
namespace PROJETO_RPG_DIO.src.entities
{
    public class Knight:Hero
    {
        public Knight(string name){
            this.name = name;
            maxHp = 300;
            maxMp = 80;
            currentHp= maxHp;
            currentMp = maxMp;
        }

        public int AttackBasic(){
            return 80;
        }

        public int SlashDemons(){
            if(currentMp>=20){
                currentMp-=20;
                Console.WriteLine("SlashDemons executa com sucesso");
                return 160;
            }
            else{
                Console.WriteLine("Infelizmente você não conseguiu executar pois não tem mana");
                return 0;
            }

        }



    }
}