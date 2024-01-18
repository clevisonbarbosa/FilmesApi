using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class CreateFilmeDto
{
    [Required(ErrorMessage = "O título do filme é obrigatório.")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O Gênero do filme é obrigatório.")]
    [StringLength(50, ErrorMessage = "O tamanho do Gênero não deve exceder 50 caracteres.")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "A duração do filme é obrigatório.")]
    [Range(70, 600, ErrorMessage = "A duração do filme deve ser de entre 70 a 600 minutos.")]
    public int Duracao { get; set; }
}

