using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortDataLayer.Crud.InterFace
{
    public interface ILinks
    {
        int Insert(AirPortModel.Models.Links obj);
        ProgressStatus Delete(int id);
        ProgressStatus Update(AirPortModel.Models.Links obj);
        List<AirPortModel.Models.Links> ToList();
        AirPortModel.Models.Links FindById(int id);
        public List<AirPortModel.Models.Links> LinkType();
        List<AirPortModel.Models.Links> PadkastCategory();
        List<AirPortModel.Models.Links> NewsCategory();
        List<AirPortModel.Models.Links> TutorialCategory();
        List<AirPortModel.Models.Links> ApplicationCategory();
        List<AirPortModel.Models.Links> ArticleCategory();
        List<AirPortModel.Models.Links> entertainmentsBook();
        List<AirPortModel.Models.Links> entertainmentVideo();
        List<AirPortModel.Models.Links> entertainmentMagazin();
        List<AirPortModel.Models.Links> entertainmentAviation();
    }
}
