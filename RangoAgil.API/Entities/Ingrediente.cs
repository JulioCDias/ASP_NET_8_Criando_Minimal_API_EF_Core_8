using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace RangoAgil.API.Entities;

public class Ingrediente
{
    [Key] // Atributo que indica que esta propriedade é a chave primária da entidade
    public int Id { get; set; }
    [Required] // Atributo que indica que esta propriedade é obrigatória
    [StringLength(100, ErrorMessage = "O nome do ingrediente deve ter no máximo 100 caracteres.")] // Atributo que define o tamanho máximo da string e uma mensagem de erro personalizada
    public required string Nome { get; set; }

    public ICollection<Rango> Rangos { get; set; } = []; // Coleção de Rangos relacionada a este Ingrediente
    // Propriedade de navegação para relacionar Ingrediente com Rango

    public Ingrediente() // Construtor padrão necessário para o Entity Framework Core
    {

    }

    [SetsRequiredMembers] // Atributo que indica que os membros obrigatórios devem ser definidos no construtor
    public Ingrediente(int id, string nome) 
    {
        Id = id;
        Nome = nome;
    }
}