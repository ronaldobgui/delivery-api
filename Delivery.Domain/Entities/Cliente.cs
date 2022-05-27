﻿using Delivery.Domain.Interfaces.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Domain.Entities
{
  [Table("Cliente")]
  public class Cliente : IBase
  {
    [Key]
    [Column("cliente_id")]
    public int Id { get; set; }

    [Column("cpf")]
    public int Cpf { get; set; }

    [Column("dt_nascimento")]
    public DateTime DataNascimento { get; set; }

    [ForeignKey("usuario_id")]
    public Usuario Usuario { get; set; }
  }
}