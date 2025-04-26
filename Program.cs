Queue<string> filaImpressora = new Queue<string>();

filaImpressora.Enqueue("Documento em PDF");
filaImpressora.Enqueue("Planilha de Excel");
filaImpressora.Enqueue("Calendário");
filaImpressora.Enqueue("Folha de pagamento");

int itensImpressora = filaImpressora.Count;

Random tempoImpressao = new Random(); 

for (int i = 0; i < itensImpressora; i++)
{
    if (filaImpressora.Count > 0)
    {
        Console.WriteLine($"imprimindo o arquivo {filaImpressora.Peek()}...\n");
         
            int tempoEspera = tempoImpressao.Next(1000, 5001);
            Thread.Sleep(tempoEspera);
            Console.WriteLine($"O arquivo {filaImpressora.Dequeue()} foi impresso com sucesso...\n");
    }
}

Console.ReadLine();