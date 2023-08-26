using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProEventos.Domain
{
    public class Evento
    {
        public int Id { get; set; }
        
        public string Local { get; set; }

        [Display(Name = "Data do evento")]
        public DateTime? DataEvento { get; set; }

        public string Tema { get; set; }

        [Display(Name = "Público")]
        public int QtdPessoas { get; set; }

        public string ImagemURL { get; set; }

        public string Telefone { get; set; }

        [Display(Name = "E-mail")]
        public string Email { get; set; }

        public IEnumerable<Lote> Lotes { get; set; }

        public IEnumerable<RedeSocial> RedesSociais { get; set; }

        public IEnumerable<PalestranteEvento> PalestrantesEventos { get; set; }
    }
}