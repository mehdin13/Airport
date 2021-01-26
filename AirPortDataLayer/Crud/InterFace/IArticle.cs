using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
    public interface IArticle
    {
        public int Insert(AirPortModel.Models.Article obj);
        public ProgressStatus Delete(int id);
        public ProgressStatus Update(AirPortModel.Models.Article obj);
        public List<AirPortModel.Models.Article> ToList();
        public AirPortModel.Models.Article FindById(int id);
    }
}
