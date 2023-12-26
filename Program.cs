﻿// Screen Sound

// camelCase
string boasVindas = "\nBoas vindas ao Screen Sound!";

// void quando a função não terá return // PascalCase
void ExibirBoasVindas()
{
    // verbatim literal
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝

░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

    Console.WriteLine(boasVindas);
}

void ExibirMenu()
{
    Console.WriteLine("\nDigite 1 para registrar banda");
    Console.WriteLine("Digite 2 para listar bandas");
    Console.WriteLine("Digite 3 para avaliar banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a opção desejada: ");
    string opçao = Console.ReadLine()!;
    int opçaoInt = int.Parse(opçao);

    switch (opçaoInt)
    {
        case 1:
            Console.WriteLine("\nVocê escolheu a opção " + opçao);
            break;
        case 2:
            Console.WriteLine("\nVocê escolheu a opção " + opçao);
            break;
        case 3:
            Console.WriteLine("\nVocê escolheu a opção " + opçao);
            break;
        case 4:
            Console.WriteLine("\nVocê escolheu a opção " + opçao);
            break;
        case -1:
            Console.WriteLine("\nObrigado por utilizar o Screen Sound!");
            break;
        default:
            Console.WriteLine("\nOpção inválida!");
            break;
    }
}

ExibirBoasVindas();
ExibirMenu();

