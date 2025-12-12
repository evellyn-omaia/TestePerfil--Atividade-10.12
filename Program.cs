using Projeto_Senai___10._12;
Perfis perfis = new Perfis();


Console.WriteLine("Informe seu nome");
string nome = Console.ReadLine();



Console.WriteLine("");
Console.WriteLine($"Olá, {nome}!");

Console.WriteLine("Vamos analisar o seu perfil!");

Console.WriteLine("");

Console.WriteLine("Responda com calma e sinceridade.");

Console.WriteLine(" Para cada pergunta, diga o quanto você se identifica: ");
Console.WriteLine(" 0 – Nada a ver");
Console.WriteLine(" 1 – Pouco");
Console.WriteLine(" 2 – Parcialmente");
Console.WriteLine(" 3 – Bastante");
Console.WriteLine(" 4 – Totalmente");
Console.WriteLine("");

int opcaoRealista = 0;
// perfis.Realista(opcaoRealista);

Console.WriteLine("");
Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
Console.WriteLine("Perfil 1 de 6");

Console.WriteLine("");

Console.WriteLine("1. Você gosta de trabalhar com ferramentas, máquinas ou objetos.");
Console.Write("Avaliação: ");
opcaoRealista = int.Parse(Console.ReadLine());
while (opcaoRealista < 1 || opcaoRealista > 4)
{
    Console.WriteLine("Avaliação inválida! Digite um número de 1 a 4.");
    Console.WriteLine("");
    Console.Write("Avaliação: ");
    opcaoRealista = int.Parse(Console.ReadLine());
}
perfis.SomaRealista += opcaoRealista;

Console.WriteLine("");

Console.WriteLine("2. Você prefere atividades práticas a discussões teóricas.");
Console.Write("Avaliação: ");
opcaoRealista = int.Parse(Console.ReadLine());
while (opcaoRealista < 1 || opcaoRealista > 4)
{
    Console.WriteLine("Avaliação inválida! Digite um número de 1 a 4.");
    Console.WriteLine("");
    Console.Write("Avaliação: ");
    opcaoRealista = int.Parse(Console.ReadLine());
}

perfis.SomaRealista += opcaoRealista;

Console.WriteLine("");

Console.WriteLine("3. Você gosta de consertar, montar ou construir coisas.");
Console.Write("Avaliação: ");
opcaoRealista = int.Parse(Console.ReadLine());

while (opcaoRealista < 1 || opcaoRealista > 4)
{
    Console.WriteLine("Avaliação inválida! Digite um número de 1 a 4.");
    Console.WriteLine("");
    Console.Write("Avaliação: ");
    opcaoRealista = int.Parse(Console.ReadLine());
}

perfis.SomaRealista += opcaoRealista;

Console.WriteLine("");

Console.WriteLine("4. Você prefere ambientes organizados e tarefas manuais.");
Console.Write("Avaliação: ");
opcaoRealista = int.Parse(Console.ReadLine());

while (opcaoRealista < 1 || opcaoRealista > 4)
{
    Console.WriteLine("Avaliação inválida! Digite um número de 1 a 4.");
    Console.WriteLine("");
    Console.Write("Avaliação: ");
    opcaoRealista = int.Parse(Console.ReadLine());
}

perfis.SomaRealista += opcaoRealista;

Console.WriteLine("");

Console.Write("Total: " + perfis.SomaRealista);



int opcaoInvestigativo = 0;
// perfis.Investigativo( opcaoInvestigativo);
Console.WriteLine("");
Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");

Console.WriteLine("Perfil 2 de 6");

Console.WriteLine("");

Console.WriteLine("1. Você gosta de resolver problemas complexos.");
Console.Write("Avaliação: ");
opcaoInvestigativo = int.Parse(Console.ReadLine());

while (opcaoInvestigativo < 1 || opcaoInvestigativo > 4)
{
    Console.WriteLine("Avaliação inválida! Digite um número de 1 a 4.");
    Console.WriteLine("");
    Console.Write("Avaliação: ");
    opcaoInvestigativo = int.Parse(Console.ReadLine());
}

perfis.SomaInvestigativo += opcaoInvestigativo;
Console.WriteLine("");

Console.WriteLine("2. Você tem interesse em ciência, pesquisa ou experimentos.");
Console.Write("Avaliação: ");
opcaoInvestigativo = int.Parse(Console.ReadLine());

while (opcaoInvestigativo < 1 || opcaoInvestigativo > 4)
{
    Console.WriteLine("Avaliação inválida! Digite um número de 1 a 4.");
    Console.WriteLine("");
    Console.Write("Avaliação: ");
    opcaoInvestigativo = int.Parse(Console.ReadLine());
}


perfis.SomaInvestigativo += opcaoInvestigativo;


Console.WriteLine("");

Console.WriteLine("3. Você gosta de analisar informações e entender como as coisas funcionam.");
Console.Write("Avaliação: ");
opcaoInvestigativo = int.Parse(Console.ReadLine());

while (opcaoInvestigativo < 1 || opcaoInvestigativo > 4)
{
    Console.WriteLine("Avaliação inválida! Digite um número de 1 a 4.");
    Console.WriteLine("");
    Console.Write("Avaliação: ");
    opcaoInvestigativo = int.Parse(Console.ReadLine());
}


perfis.SomaInvestigativo += opcaoInvestigativo;

Console.WriteLine("");

Console.WriteLine("4. Você prefere atividades que envolvam reflexão e lógica.");
Console.Write("Avaliação: ");
opcaoInvestigativo = int.Parse(Console.ReadLine());

while (opcaoInvestigativo < 1 || opcaoInvestigativo > 4)
{
    Console.WriteLine("Avaliação inválida! Digite um número de 1 a 4.");
    Console.WriteLine("");
    Console.Write("Avaliação: ");
    opcaoInvestigativo = int.Parse(Console.ReadLine());
}

perfis.SomaInvestigativo += opcaoInvestigativo;
Console.Write("Total: " + perfis.SomaInvestigativo);


int opcaoArtístico = 0;
// perfis.Artístico(opcaoArtístico);
Console.WriteLine("");
Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");

Console.WriteLine("Perfil 3 de 6");

Console.WriteLine("");

Console.WriteLine("1. Você gosta de criar, desenhar, inventar ou expressar ideias.");
Console.Write("Avaliação: ");
opcaoArtístico = int.Parse(Console.ReadLine());

while (opcaoArtístico < 1 || opcaoArtístico > 4)
{
    Console.WriteLine("Avaliação inválida! Digite um número de 1 a 4.");
    Console.WriteLine("");
    Console.Write("Avaliação: ");
    opcaoArtístico = int.Parse(Console.ReadLine());
}
perfis.SomaArtístico += opcaoArtístico;

Console.WriteLine("");

Console.WriteLine("2. Você prefere atividades com liberdade e sem regras rígidas.");
Console.Write("Avaliação: ");
opcaoArtístico = int.Parse(Console.ReadLine());

while (opcaoArtístico < 1 || opcaoArtístico > 4)
{
    Console.WriteLine("Avaliação inválida! Digite um número de 1 a 4.");
    Console.WriteLine("");
    Console.Write("Avaliação: ");
    opcaoArtístico = int.Parse(Console.ReadLine());
}

perfis.SomaArtístico += opcaoArtístico;

Console.WriteLine("");

Console.WriteLine("3. Você gosta de música, artes visuais, escrita ou atuação.");
Console.Write("Avaliação: ");
opcaoArtístico = int.Parse(Console.ReadLine());

while (opcaoArtístico < 1 || opcaoArtístico > 4)
{
    Console.WriteLine("Avaliação inválida! Digite um número de 1 a 4.");
    Console.WriteLine("");
    Console.Write("Avaliação: ");
    opcaoArtístico = int.Parse(Console.ReadLine());
}

perfis.SomaArtístico += opcaoArtístico;

Console.WriteLine("");

Console.WriteLine("4. Você é imaginativo(a) e busca formas diferentes de fazer as coisas.");
Console.Write("Avaliação: ");
opcaoArtístico = int.Parse(Console.ReadLine());

while (opcaoArtístico < 1 || opcaoArtístico > 4)
{
    Console.WriteLine("Avaliação inválida! Digite um número de 1 a 4.");
    Console.WriteLine("");
    Console.Write("Avaliação: ");
    opcaoArtístico = int.Parse(Console.ReadLine());
}

perfis.SomaArtístico += opcaoArtístico;
Console.WriteLine("");

Console.WriteLine("");
Console.Write("Total: " + perfis.SomaArtístico);


int opcaoSocial = 0;
// perfis.Social(opcaoSocial);

Console.WriteLine("");
Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");


Console.WriteLine("");

Console.WriteLine("Perfil 4 de 6");
Console.WriteLine("");

Console.WriteLine("1. Você gosta de ajudar, orientar ou cuidar de pessoas.");
Console.Write("Avaliação: ");
opcaoSocial = int.Parse(Console.ReadLine());

while (opcaoSocial < 1 || opcaoSocial > 4)
{
    Console.WriteLine("Avaliação inválida! Digite um número de 1 a 4.");
    Console.WriteLine("");
    Console.Write("Avaliação: ");
    opcaoSocial = int.Parse(Console.ReadLine());
}

perfis.SomaSocial += opcaoSocial;

Console.WriteLine("");

Console.WriteLine("2. Você tem facilidade para ouvir e compreender os outros.");
Console.Write("Avaliação: ");
opcaoSocial = int.Parse(Console.ReadLine());

while (opcaoSocial < 1 || opcaoSocial > 4)
{
    Console.WriteLine("Avaliação inválida! Digite um número de 1 a 4.");
    Console.WriteLine("");
    Console.Write("Avaliação: ");
    opcaoSocial = int.Parse(Console.ReadLine());
}

perfis.SomaSocial += opcaoSocial;

Console.WriteLine("");

Console.WriteLine("3. Você prefere atividades que envolvem ensinar ou apoiar alguém.");
Console.Write("Avaliação: ");
opcaoSocial = int.Parse(Console.ReadLine());

while (opcaoSocial < 1 || opcaoSocial > 4)
{
    Console.WriteLine("Avaliação inválida! Digite um número de 1 a 4.");
    Console.WriteLine("");
    Console.Write("Avaliação: ");
    opcaoSocial = int.Parse(Console.ReadLine());
}
perfis.SomaSocial += opcaoSocial;

Console.WriteLine("");


Console.WriteLine("4. Você gosta de trabalhar em equipe e apoiar o bem-estar coletivo.");
Console.Write("Avaliação: ");
opcaoSocial = int.Parse(Console.ReadLine());

while (opcaoSocial < 1 || opcaoSocial > 4)
{
    Console.WriteLine("Avaliação inválida! Digite um número de 1 a 4.");
    Console.WriteLine("");
    Console.Write("Avaliação: ");
    opcaoSocial = int.Parse(Console.ReadLine());
}

perfis.SomaSocial += opcaoSocial;

Console.WriteLine("");
Console.Write("Total: " + perfis.SomaSocial);

int opcaoEmpreendedor = 0;
// perfis.Empreendedor( opcaoEmpreendedor);


Console.WriteLine("");
Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////////");


Console.WriteLine("");

Console.WriteLine("Perfil 5 de 6");
Console.WriteLine("");

Console.WriteLine("1. Você gosta de liderar, convencer ou motivar pessoas.");
Console.Write("Avaliação: ");
opcaoEmpreendedor = int.Parse(Console.ReadLine());

while (opcaoEmpreendedor < 1 || opcaoEmpreendedor > 4)
{
    Console.WriteLine("Avaliação inválida! Digite um número de 1 a 4.");
    Console.WriteLine("");
    Console.Write("Avaliação: ");
    opcaoEmpreendedor = int.Parse(Console.ReadLine());
}

perfis.SomaEmpreendedor += opcaoEmpreendedor;

Console.WriteLine("");

Console.WriteLine("2. Você tem iniciativa e gosto de tomar decisões.");
Console.Write("Avaliação: ");
opcaoEmpreendedor = int.Parse(Console.ReadLine());

while (opcaoEmpreendedor < 1 || opcaoEmpreendedor > 4)
{
    Console.WriteLine("Avaliação inválida! Digite um número de 1 a 4.");
    Console.WriteLine("");
    Console.Write("Avaliação: ");
    opcaoEmpreendedor = int.Parse(Console.ReadLine());
}
perfis.SomaEmpreendedor += opcaoEmpreendedor;

Console.WriteLine("");

Console.WriteLine("3. Você prefere desafios que envolvam resultados e metas.");
Console.Write("Avaliação: ");
opcaoEmpreendedor = int.Parse(Console.ReadLine());

while (opcaoEmpreendedor < 1 || opcaoEmpreendedor > 4)
{
    Console.WriteLine("Avaliação inválida! Digite um número de 1 a 4.");
    Console.WriteLine("");
    Console.Write("Avaliação: ");
    opcaoEmpreendedor = int.Parse(Console.ReadLine());
}

perfis.SomaEmpreendedor += opcaoEmpreendedor;

Console.WriteLine("");

Console.WriteLine("4. Você gosta de criar projetos e colocar ideias em prática.");
Console.Write("Avaliação: ");
opcaoEmpreendedor = int.Parse(Console.ReadLine());

while (opcaoEmpreendedor < 1 || opcaoEmpreendedor > 4)
{
    Console.WriteLine("Avaliação inválida! Digite um número de 1 a 4.");
    Console.WriteLine("");
    Console.Write("Avaliação: ");
    opcaoEmpreendedor = int.Parse(Console.ReadLine());
}
perfis.SomaEmpreendedor += opcaoEmpreendedor;

Console.WriteLine("");
Console.Write("Total: " + perfis.SomaEmpreendedor);

int opcaoConvencional = 0;
// perfis.Convencional(opcaoConvencional);


Console.WriteLine("");
Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////////");


Console.WriteLine("");

Console.WriteLine("Perfil 6 de 6");
Console.WriteLine("");

Console.WriteLine("1. Você gosta de organizar, planejar e manter tudo em ordem.");
Console.Write("Avaliação: ");
opcaoConvencional = int.Parse(Console.ReadLine());

while (opcaoConvencional < 1 || opcaoConvencional > 4)
{
    Console.WriteLine("Avaliação inválida! Digite um número de 1 a 4.");
    Console.WriteLine("");
    Console.Write("Avaliação: ");
    opcaoConvencional = int.Parse(Console.ReadLine());
}
perfis.SomaConvencional += opcaoConvencional;

Console.WriteLine("");

Console.WriteLine("2. Você prefere atividades com regras claras e rotina.");
Console.Write("Avaliação: ");
opcaoConvencional = int.Parse(Console.ReadLine());

perfis.SomaConvencional += opcaoConvencional;

Console.WriteLine("");

Console.WriteLine("3. Você gosta de trabalhar com documentos, tabelas ou registros.");
Console.Write("Avaliação: ");
opcaoConvencional = int.Parse(Console.ReadLine());

perfis.SomaConvencional += opcaoConvencional;
Console.WriteLine("");

Console.WriteLine("4. Você é detalhista e cuidadoso(a) com informações.");
Console.Write("Avaliação: ");
opcaoConvencional = int.Parse(Console.ReadLine());

perfis.SomaConvencional += opcaoConvencional;

Console.WriteLine("");

Console.WriteLine("");
Console.Write("Total: " + perfis.SomaConvencional);



int[] vetorSomas = { perfis.SomaRealista, perfis.SomaInvestigativo, perfis.SomaArtístico, perfis.SomaSocial, perfis.SomaEmpreendedor, perfis.SomaConvencional };

Console.WriteLine("");

perfis.Tabela();

perfis.VerificarPerfil(vetorSomas, nome);
