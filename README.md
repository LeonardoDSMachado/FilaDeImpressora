# FilaDeImpressora

Nesse exercicio o objetivo era simular a fila de uma impressora com tempo de espera entre os itens a serem impressos.

Implementar um programa que simula uma fila de impressão seguindo o seguinte roteiro:
• Crie uma variável do tipo Queue<string> para representar a fila de impressão.
• Crie um loop que irá executar até que a fila de impressão esteja vazia.
• Dentro do loop, verifique se a fila de impressão não está vazia. Se não estiver vazia, remova o primeiro
elemento da fila usando o método Dequeue() e imprima na tela que o arquivo "X" está sendo impresso.
• Simule o tempo de impressão com um Thread.Sleep() por um período aleatório de tempo entre 1 e 5
segundos.
• Após simular a impressão do arquivo, imprima na tela que o arquivo "X" foi impresso com sucesso.
• Repita os passos 3 a 5 até que a fila de impressão esteja vazia.
