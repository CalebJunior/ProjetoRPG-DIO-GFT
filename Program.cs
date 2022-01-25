using System;
using PROJETO_RPG_DIO.src.entities;

namespace PROJETO_RPG_DIO;


class Program{

    static void Main(string[] args){
        
        int opcao;


        Console.WriteLine("\nProjeto RPG DIO/GFT");
        Console.WriteLine("\n\nO que deseja fazer ?\n1-Jogar uma partida \n2-Sair do jogo");
        opcao = int.Parse(Console.ReadLine());

        if(opcao==2)
            Environment.Exit(0);

        Console.WriteLine("\n\nInstruções: Com uma equipe de dois knghts um mago e um ninja derrote o chefão final");
        string nomePersonagem;
        
        Console.WriteLine($"\nConstrução do knight 1");
        Console.WriteLine("Qual será seu nome ?");
        Knight kn1= new Knight(Console.ReadLine());
            
        Console.WriteLine($"\nConstrução do knight 2");
        Console.WriteLine("Qual será seu nome ?");
        Knight kn2= new Knight(Console.ReadLine());

        Console.WriteLine($"\nConstrução do mago");
        Console.WriteLine("Qual será seu nome ?");
        Wizard wz= new Wizard(Console.ReadLine());

        Console.WriteLine($"\nConstrução do ninja");
        Console.WriteLine("Qual será seu nome ?");
        Ninja nnj= new Ninja(Console.ReadLine());
        
        int hpBoss=5000;
        Random playerAttacked = new Random();
        int attkBoss;
        int escolhas;
        while(hpBoss>0 && ((kn1.StatusHealth()>0) || (kn2.StatusHealth()>0) || (wz.StatusHealth()>0) || (nnj.StatusHealth()>0) )){
            if(kn1.StatusHealth()>0){
                Console.Write($"Status do seu knight {kn1.name} ");
                kn1.AllStatus();

                Console.WriteLine("Qual ação deseja tomar: \n1-Attack Basic\n2-SlashDemons(Consome 20 MP)");
                escolhas = int.Parse(Console.ReadLine());

                switch(escolhas){
                    case 1:
                        hpBoss-=kn1.AttackBasic();
                        Console.WriteLine($"\n\nVida do Chefão{hpBoss}");
                        break;

                    case 2:
                        hpBoss-=kn1.SlashDemons();
                        Console.WriteLine($"\n\nVida do Chefão: {hpBoss}");
                        break;
                }

            }
            else{
                Console.WriteLine($"Seu knight {kn1.name} está morto");
            }



            if(kn2.StatusHealth()>0){
                Console.Write($"Status do seu knight {kn2.name} ");
                kn2.AllStatus();

                Console.WriteLine("Qual ação deseja tomar: \n1-Attack Basic\n2-SlashDemons(Consome 20 MP)");
                escolhas = int.Parse(Console.ReadLine());

                switch(escolhas){
                    case 1:
                        hpBoss-=kn2.AttackBasic();
                        Console.WriteLine($"\n\nVida do Chefão{hpBoss}");
                        break;

                    case 2:
                        hpBoss-=kn2.SlashDemons();
                        Console.WriteLine($"\n\nVida do Chefão: {hpBoss}");
                        break;
                }

            }
            else{
                Console.WriteLine($"Seu knight {kn2.name} está morto");
            }



            if(wz.StatusHealth()>0){
                Console.Write($"Status do seu mago {wz.name} ");
                wz.AllStatus();

                Console.WriteLine("Qual ação deseja tomar: \n1-Attack Basic\n2-FireBall(Consome 100 MP)");
                escolhas = int.Parse(Console.ReadLine());

                switch(escolhas){
                    case 1:
                        hpBoss-=wz.AttackBasic();
                        Console.WriteLine($"\n\nVida do Chefão{hpBoss}");
                        break;

                    case 2:
                        hpBoss-=wz.FireBall();
                        Console.WriteLine($"\n\nVida do Chefão: {hpBoss}");
                        break;
                }

            }
            else{
                Console.WriteLine($"Seu Mago {wz.name} está morto");
            }



            if(nnj.StatusHealth()>0){

                Console.Write($"Status do seu ninja {nnj.name} ");
                nnj.AllStatus();

                Console.WriteLine("Qual ação deseja tomar: \n1-Attack Basic\n2-ShadowKiller(Consome 60 MP)");
                escolhas = int.Parse(Console.ReadLine());

                switch(escolhas){
                    case 1:
                        hpBoss-=nnj.AttackBasic();
                        Console.WriteLine($"\n\nVida do Chefão{hpBoss}");
                        break;

                    case 2:
                        hpBoss-=nnj.ShadowKiller();
                        Console.WriteLine($"\n\nVida do Chefão: {hpBoss}");
                        break;
                }

            }
            else{
                Console.WriteLine($"Seu Ninja {nnj.name} está morto");
            }

            attkBoss = playerAttacked.Next(1,5);

            switch(attkBoss){
                case 1:
                    if(kn1.StatusHealth()>0){
                        Console.WriteLine($"O Chefão atacou o knight {kn1.name} ");
                        kn1.Damage();
                    }
                    else{
                        Console.WriteLine("O chefão não atacou");
                    }
                    break;

                case 2:
                     if(kn2.StatusHealth()>0){
                        Console.WriteLine($"O Chefão atacou o knight {kn2.name} ");
                        kn2.Damage();
                    }
                    else{
                        Console.WriteLine("O chefão não atacou");
                    }
                    break;


                case 3:
                    if(wz.StatusHealth()>0){
                        Console.WriteLine($"O Chefão atacou o wizard {wz.name} ");
                        wz.Damage();
                    }
                    else{
                        Console.WriteLine("O chefão não atacou");
                    }
                    break;


                case 4:
                    if(kn1.StatusHealth()>0){
                        Console.WriteLine($"O Chefão atacou o ninja {nnj.name} ");
                        nnj.Damage();
                    }
                    else{
                        Console.WriteLine("O chefão não atacou");
                    }
                    break;



            }


        }

        if(hpBoss>0){
            Console.WriteLine("Você perdeu");

        }
        else{
            Console.WriteLine("Parabéns você ganhou");
        }
    }

}