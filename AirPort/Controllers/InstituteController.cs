using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirPort.Model.ViewModel;
using AirPortDataLayer.Crud.InterFace;

namespace AirPort.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InstituteController : Controller
    {
        private readonly IPlace _place;
        private readonly IAddress _address;
        private readonly ILinks _links;
        private readonly IDetail _detail;
        private readonly IGallery _gallery;
        private readonly ICategory _category;
        public InstituteController (IPlace place ,IAddress address,IDetail detail,ILinks links,IGallery gallery,ICategory category)
        {
            _place = place;
            _address = address;
            _detail = detail;
            _links = links;
            _gallery = gallery;
            _category = category;
        }
        [HttpGet]
        [Route("InstituteList")]
        public JsonInstitute InstituteList()
        {
            JsonInstitute jsonInstitute = new JsonInstitute();
            InstituteViewModel instituteListObj = new InstituteViewModel();
            List<InstituteViewModel> institutesLinkListObj = new List<InstituteViewModel>();
            try
            {
                var instituteLists = _place.PlacesInstitute();
                foreach (var item in instituteLists)
                {
                    instituteListObj.Logo = _links.FindById(item.Id).Icon;
                    instituteListObj.Title = _links.FindById(item.Id).Title;
                    instituteListObj.Description = _links.FindById(item.Id).Description;
                    instituteListObj.WebUrl = _links.FindById(item.Id).Url;
                    instituteListObj.Phone = item.PhoneNumber;
                    instituteListObj.CatagoriId = item.CategoryId;
                    instituteListObj.AddressId = _address.FindById(item.AdressId).Detail;
                    instituteListObj.LocationX = _address.FindById(item.AdressId).LocationX;
                    instituteListObj.LocationY = _address.FindById(item.AdressId).LocationY;
                    instituteListObj.LocationR = _address.FindById(item.AdressId).LocationR;
                    institutesLinkListObj.Add(instituteListObj);
                }
                jsonInstitute.Result = institutesLinkListObj;
                return jsonInstitute;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                return jsonInstitute;
            }
        }
    }
}
