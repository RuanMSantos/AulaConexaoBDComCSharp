using AulaConexaoBDComCSharp.db;

Console.WriteLine("Tarefas encontradas:");

int numeroTarefas = 0;

using (var _db = new TarefasContext()){
    
    var tarefas = _db.Tarefa;

    numeroTarefas = tarefas.Count();
}


Console.WriteLine($"Foram encontradas {numeroTarefas} tarefas.");