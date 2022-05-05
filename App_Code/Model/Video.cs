using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M05_UF3_P2_Template.App_Code.Model
{
    public class Video
    {
        public int Id { get; set; }
        public int Product_Id { get; set; }
        public float Duration { get; set; }

        public Video()
        {

        }
        public Video(DataRow row)
        {

        }
        public Video(int id) : this(DatabaseManager.Select("Vídeo", null, "Id = " + id + " ").Rows[0]) { }

        public void Update()
        {

        }
        public void Add()
        {

        }
        public void Remove()
        {

        }
    }
}
