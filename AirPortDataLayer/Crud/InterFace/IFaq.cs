using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
    public interface IFaq
    {
        public int Insert(AirPortModel.Models.Faq obj);
        public ProgressStatus Delete(int id);
        public ProgressStatus Update(AirPortModel.Models.Faq obj);
        public List<AirPortModel.Models.Faq> ToList();
        public AirPortModel.Models.Faq FindById(int id);
    }
}
