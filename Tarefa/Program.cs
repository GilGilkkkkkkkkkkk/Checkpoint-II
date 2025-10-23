﻿// See https://aka.ms/new-console-template for more information //
Console.WriteLine("Sistema de Tarefas");

Console.WriteLine("Preenchendo dados tarefa 01");
var tarefa01 = new Tarefa();
tarefa01.Nome = "Fazendo uma Comprinha";
tarefa01.Descricao  = "Balas, Doces e Salgadinhos";
tarefa01.DataCriacao = DateTime.Now; 
tarefa01.Status = 1;
tarefa01.DataExecucao = null;
Console.WriteLine("Dados tarefa quase preenchidos");
Console.WriteLine("Colocando infomações no Banco");
var operacoes = new Operacoes();
int idInserido = operacoes.Criar(tarefa01);
Console.WriteLine($"Dados Colocado no banco de dados com perfeição. Id: {idInserido}");