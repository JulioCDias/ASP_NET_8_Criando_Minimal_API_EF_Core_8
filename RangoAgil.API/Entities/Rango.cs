
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace RangoAgil.API.Entities;

public class Rango
{
    [Key] // Atributo que indica que esta propriedade é a chave primária da entidade
    public int Id { get; set; }
    [Required] // Atributo que indica que esta propriedade é obrigatória
    [StringLength(100, ErrorMessage = "O nome do rango deve ter no máximo 100 caracteres.")] // Atributo que define o tamanho máximo da string e uma mensagem de erro personalizada
    public required string Nome { get; set; }

    public ICollection<Ingrediente> Ingredientes { get; set; } = []; // Inicializa a coleção de ingredientes como uma lista vazia
// A propriedade Ingredientes é uma coleção que representa os ingredientes associados a este rango

    public Rango() // Construtor padrão necessário para o Entity Framework Core
    {

    }

    [SetsRequiredMembers] // Atributo que indica que os membros obrigatórios devem ser definidos no construtor
    public Rango(int id, string nome) 
    {
        Id = id;
        Nome = nome;
    }
}
