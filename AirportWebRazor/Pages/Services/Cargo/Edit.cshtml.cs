using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace AirportWebRazor.Pages.Services.Cargo
{
    public class EditModel : PageModel
    {
        private readonly IPlace _place;
        private readonly IAddress _address;
        private readonly ICategory _category;
        private readonly IGallery _gallery;
        private readonly IGalleryImage _galleryImage;
        private readonly IDetail _detail;
        private readonly IFeatrue _featrue;
        private readonly IDetailValue _detailValue;
        private readonly ICity _city;
        private readonly IState _state;
        private readonly IAirPort _airport;
        private readonly ICustomer _customer;

        public EditModel(IPlace place, IAddress address, ICategory category, IGallery gallery, IGalleryImage galleryImage, IDetail detail, IFeatrue featrue, IDetailValue detailValue, ICity city, IState state, IAirPort airPort, ICustomer customer)
        {
            _place = place;
            _address = address;
            _category = category;
            _gallery = gallery;
            _galleryImage = galleryImage;
            _detail = detail;
            _featrue = featrue;
            _detailValue = detailValue;
            _state = state;
            _city = city;
            _airport = airPort;
            _customer = customer;
        }
        [BindProperty]
        public AirPortModel.Models.Place placeobj { get; set; }


        public async Task<IActionResult> OnGet(int id)
        {
            placeobj = _place.FindById(id);
            ViewData["Addresses"] = _address.FindById(id);
            ViewData["Statees"] = _state.ToList();
            ViewData["Cityes"] = _city.ToList();
            ViewData["Feathrue"] = _featrue.ToListbyid(13);
            ViewData["Airport"] = _airport.Tolist();
            ViewData["Customer"] = _customer.ToList();

            return Page();
        }


        public async Task<IActionResult> OnPost(int[] id, string[] value, List<IFormFile> images, string Detail, string LocationX, string LocationY, string LocationR, int CityId)
        {
            try
            {
                //Update into address
                AirPortModel.Models.Address addressObj = new AirPortModel.Models.Address();
                if (Detail != null && LocationX != null && LocationY != null && LocationR != null && CityId != null)
                {
                    addressObj.LocationR = LocationR;
                    addressObj.LocationX = LocationX;
                    addressObj.LocationY = LocationY;
                    addressObj.Detail = Detail;
                    addressObj.CityId = CityId;
                    addressObj.Id = placeobj.AdressId;
                    var adid = _address.Update(addressObj);

                    if (adid.Number.Equals(1))
                    {
                        placeobj.AdressId = addressObj.Id;
                    }
                    else
                    {
                        return Page();
                    }

                    placeobj.CategoryId = 9;
                    AirPortModel.Models.Detail detailobj = new AirPortModel.Models.Detail();

                    if (_place.Update(placeobj).Number.Equals(1))
                    {
                        return Redirect("index");
                    }
                    else
                    {
                        return Redirect("index");
                    }
                }
            }


            catch (Exception ex)
            {
                string mes = ex.Message;
                return Page();
            }
            return Redirect("index");
        }
    }
}
