﻿using System;
using System.Collections.Generic;
using System.Text;
using AirPortDataLayer.Crud.VeiwModel;

namespace AirPortDataLayer.Crud.InterFace
{
    public interface IAirPort
    {
        int Insert(AirPortModel.Models.AirPort obj);
        string Delete(int id);
        string Update(AirPortModel.Models.AirPort obj);
        List<AirPortModel.Models.AirPort> Tolist();
        AirPortModel.Models.AirPort FindById(int id);
        List<FeatureValueVeiwModel> AirportDetail(int id);
        List<ImageList> AirPortGallery(int id);
        public ProgressStatus CheckAirportCode(string code);
    }
}