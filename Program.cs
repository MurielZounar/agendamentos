int duracaoMunitos = 45;
decimal precoCorte = 50;
decimal precoBarba = 40;

void Menu()
{
    bool continua = true;
    
    while (continua)
    {
        Console.Clear();
        Console.WriteLine("========== MENU ==========");
        Console.WriteLine("1. Agendar");
        Console.WriteLine("2. Agendamentos do dia");
        Console.WriteLine("3. Cancelar Agendamento");
        Console.WriteLine("0. Sair");
        Console.WriteLine("");
        Console.Write("Informe a opção desejada");

        int opcao;
        int.TryParse(Console.ReadLine(), out opcao);

        switch (opcao)
        {
            case 1:

            case 2:
            case 3:
            case 0:

            default:
        }
    }
    
}

void Agendar()
{
    int servico;
    string nomeCliente;
    DateTime dataAgendamento;
    TimeOnly inicioServico;
    TimeOnly fimServico;
    TimeOnly horarioAbertura = new TimeOnly(9,0);
    TimeOnly horarioFechamento = new TimeOnly(18,0);

    CabecalhoAgendamento();
    Console.Write("Informe seu nome: ");
    nomeCliente = Console.ReadLine();

    CabecalhoAgendamento();
    Console.WriteLine("1. Somente Corte");
    Console.WriteLine("2. Somente Barba");
    Console.WriteLine("3. Corte e Barba");
    Console.WriteLine("");
    Console.Write("Selecione o serviço que deseja agendar: ");
    int.TryParse(Console.ReadLine(), out servico);

    do
    {
        CabecalhoAgendamento();
        Console.Write("Data do agendamento (dd/mm/aaaa): ");
        DateTime.TryParse(Console.ReadLine(), out dataAgendamento);
        
        if (dataAgendamento < DateTime.Now.Date)
        {
            Console.WriteLine("A data do agendamento não pode ser menor que a data atual.");
        }
    } while (dataAgendamento < DateTime.Now.Date);

    do
    {
        CabecalhoAgendamento();
        Console.Write("Horário (hh/mm): ");
        TimeOnly.TryParse(Console.ReadLine(), out inicioServico);
        fimServico = inicioServico.AddMinutes(duracaoMunitos);

        if (inicioServico < TimeOnly.FromDateTime(DateTime.Now))
        {
            Console.WriteLine("O horário do agendamento não pode ser menor que a hora atual.");
        }
        else if (inicioServico < horarioAbertura || inicioServico > horarioFechamento)
        {
            Console.WriteLine("O horário informado está fora do horário de expediente.");
        }
    } while ((inicioServico < TimeOnly.FromDateTime(DateTime.Now)) || (inicioServico < horarioAbertura || inicioServico > horarioFechamento));

    Console.WriteLine($"Cliente: {nomeCliente}");
    Console.WriteLine($"Serviço: {}");
    Console.WriteLine($"Horário: {inicioServico} às {fimServico}");
    Console.WriteLine($"Valor: R${preco.ToString("0.00")}");
}

void ListarDoDia()
{
    
}

void Cancelar()
{
    
}

void TemConflito()
{
    
}

void CabecalhoAgendamento()
{
    Console.Clear();
    Console.WriteLine("========== Agendar ==========");   
    Console.WriteLine("");   
}