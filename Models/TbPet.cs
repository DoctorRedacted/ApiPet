using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ApiPet.Models;

[Table("tb_pet")]
public partial class TbPet
{
    [Key]
    [Column("id_pet")]
    public int IdPet { get; set; }

    [Column("nm_nome")]
    [StringLength(50)]
    public string? NmNome { get; set; }

    [Column("vl_idade")]
    public int? VlIdade { get; set; }

    [Column("dt_nascimento")]
    public DateOnly? DtNascimento { get; set; }
}
