> Obs: Esse projeto é um exemplo de implementação do padrão Observer em um sistema de coleta de dados via sensores. Foi desenvolvido durante a disciplina de Projeto Orientado a Objeto na Universidade Federal de São Paulo (UNIFESP - SJC).

# Padrão Observer em um Sistema de Coleta de Dados

Organizações brasileiras, como universidades e instituições de pesquisa, precisam acompanhar em tempo real os dados coletados por sensores instalados em rios da Amazônia. Esses sensores monitoram variáveis como temperatura, pH e umidade do ar, gerando informações contínuas que devem ser distribuídas automaticamente para diferentes interessados sempre que houver atualização. Para atender a essa necessidade, este projeto implementa um sistema baseado no padrão Observer, permitindo que múltiplos observadores recebam notificações de forma desacoplada e eficiente sempre que os dados dos sensores forem alterados.

## Estrutura do Projeto

O projeto está organizado em arquivos pequenos e focados, seguindo a ideia de separar responsabilidades entre sujeito, observadores e sensores:

- `Program.cs`: ponto de entrada da aplicação. Cria os sensores, registra os observadores e executa as coletas de dados.
- `DataCollector.cs`: coordena a atualização dos sensores e centraliza a chamada para envio dos valores coletados.
- `Subject.cs`: classe base que mantém a lista de observadores e dispara as notificações quando um valor muda.
- `IObserver.cs`: define o contrato que todos os observadores devem implementar.
- `Temperature.cs`, `PH.cs` e `Humidity.cs`: representam os sensores monitorados. Cada um armazena seu valor atual e notifica os observadores quando recebe uma atualização.
- `UNIFESPObserver.cs`, `USPObserver.cs` e `UFRGSObserver.cs`: implementam os observadores concretos que recebem e exibem as notificações enviadas pelos sensores.

Essa estrutura permite adicionar novos sensores ou novos observadores sem precisar alterar a lógica principal do sistema, mantendo o código desacoplado e fácil de manter.

