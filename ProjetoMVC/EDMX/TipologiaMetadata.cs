using GridMvc.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoMVC.EDMX
{
    [GridTable(PageSize = 10, PagingEnabled = true)]
    public class TipologiaMetadata
    {
        [GridHiddenColumn]
        public int CO_TIPOLOGIA { get; set; }

        [GridColumn(Title = "Nome")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Nome")]
        public string NO_TIPOLOGIA { get; set; }

        [GridColumn(Title = "Tipo", SortEnabled = true)]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string TIPO_HABITACAO { get; set; }

        public int AREA_PRIVATIVA { get; set; }
      
        public string RENDA_FAM { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> VALOR_INICIAL { get; set; }

        public Nullable<decimal> VALOR_FINAL { get; set; }
    }
}