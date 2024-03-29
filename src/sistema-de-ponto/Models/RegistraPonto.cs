﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Collections.Generic;

namespace sistema_de_ponto.Models
{
    [Table("RegistraPontos")]
    public class RegistraPonto
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Funcionario")]
        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; } = null!;


        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }

        [Display(Name = "1 Entrada")]
        [DisplayFormat(DataFormatString = "{0:HH\\:mm\\:ss}")]
        public DateTime? HoraEntrada1 { get; set; }


        [Display(Name = "1 Saída")]
        [DisplayFormat(DataFormatString = "{0:HH\\:mm\\:ss}")]
        public DateTime? HoraSaida1 { get; set; }


        [Display(Name = "2 Entrada")]
        [DisplayFormat(DataFormatString = "{0:HH\\:mm\\:ss}")]
        public DateTime? HoraEntrada2 { get; set; }

        [Display(Name = "2 Saída")]
        [DisplayFormat(DataFormatString = "{0:HH\\:mm\\:ss}")]
        public DateTime? HoraSaida2 { get; set; }

        [NotMapped]
        [Display(Name = "Intervalo")]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm\\:ss}")]
        public TimeSpan? Intervalo
        {
            get
            { 
                if(HoraEntrada2.HasValue)
                {
                    return (TimeSpan)(HoraSaida1 - HoraEntrada2);
                }
                else
                {
                    return TimeSpan.Zero;
                }
            
            }
        }

        [NotMapped]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm\\:ss}")]
        public TimeSpan? TotalDeHoras
        {
            get
            {
                if (HoraSaida2.HasValue)
                {
                    var jornada1 = (TimeSpan)(HoraSaida1 - HoraEntrada1);
                    var jornada2 = (TimeSpan)(HoraSaida2 - HoraEntrada2);

                    return jornada1 + jornada2;
                }
                else if (HoraSaida1.HasValue)
                {
                    return (TimeSpan)(HoraSaida1.Value - HoraEntrada1);
                }
                else
                {
                    return TimeSpan.Zero;
                }
            }
        }
        


    }


}


