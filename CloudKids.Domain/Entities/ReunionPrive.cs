using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudKids.Domain.Entities
{
     public class ReunionPrive
    {

        public int Id { get; set; }

       
        public String LieuRdvP { get; set; }

        public String DateRdvP { get; set; }
        public String MotifRdvP { get; set; }

        public String Categories { get; set; }

        public String Imporatances { get; set; }
        public Profil_Parent Parent { get; set; }
       
        [ForeignKey("Parent")]
        public int ParentFk { get; set; }

        public Profil_Directeur Directeur { get; set; }

        [ForeignKey("Directeur")]
        public int DirecteurFk { get; set; }
      

    }

  
   
}
