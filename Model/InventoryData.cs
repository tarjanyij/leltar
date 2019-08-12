using System.ComponentModel.DataAnnotations;

namespace Inventory.Model
{
    public class InventoryData
    {
        public int Id { get; set; }
        public int EszkozAzon { get; set; }
        public string LeltariSzam { get; set; }
        public string Vonalkod { get; set; }
        public string Megnevezes { get; set; }
        public string GyariSzam { get; set; }
        public int Mennyiseg { get; set; }
        public string LeltarKorzet { get; set; }
        public string  LeltarKorzetMegnevezes { get; set; }

        [DataType(DataType.Date)]   
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public System.DateTime  HasznalatbaVetelDatuma { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
         public System.DateTime ElhelyezesIdeje { get; set; }
        public int BruttoErtek { get; set; }
        public int LeltSzemely { get; set; }
        public string LeltSzemelyNeve { get; set; }
    }
}