using System.Collections.Generic;

namespace AirPortDataLayer.Crud.InterFace
{
    public interface IRaiting
    {
        public int Insert(AirPortModel.Models.Raiting obj);
        public ProgressStatus Delete(int id);
        public ProgressStatus Update(AirPortModel.Models.Raiting obj);
        public List<AirPortModel.Models.Raiting> ToList();
        public AirPortModel.Models.Raiting FindById(int id);
    }
}
