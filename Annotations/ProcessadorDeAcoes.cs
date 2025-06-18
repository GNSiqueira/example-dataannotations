using System;
using System.Reflection;
using Teste_Data_Annotation.Acoes;
using Teste_Data_Annotation.MinhasAcoes; // Importa a base das ações

namespace Teste_Data_Annotation.Processadores
{
    public static class ProcessadorDeAcoes
    {
        public static void ExecutarAcoes(object obj)
        {
            Console.WriteLine($"\nProcessando ações para o objeto do tipo '{obj.GetType().Name}'...");

            // Pega todas as propriedades do objeto
            var propriedades = obj.GetType().GetProperties();

            foreach (var propriedade in propriedades)
            {

                Console.WriteLine($"\nAnalisando a propriedade '{propriedade}'...");
                // Para cada propriedade, pega SÓ as anotações que herdam da nossa base 'AcaoAttribute'
                var acoes = propriedade.GetCustomAttributes<BaseAttribute>(true);

                if (!acoes.Any())
                    continue;

                // Itera sobre cada anotação de ação encontrada (ex: [Printar])
                foreach (var acao in acoes)
                {
                    Console.WriteLine($"Encontradas {acao.GetType().Name} anotações.");
                    // Executa a ação específica daquela anotação
                    acao.Executar(propriedade, obj);
                }
            }
        }
    }
}