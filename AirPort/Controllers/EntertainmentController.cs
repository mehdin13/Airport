using Microsoft.AspNetCore.Mvc;
using System;
using AirPortDataLayer.Crud.InterFace;
using System.Collections.Generic;
using AirPort.Model.ViewModel;

namespace AirPort.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EntertainmentController : ControllerBase
    {
        private readonly IEntertainment _entertainment;
        private readonly ILinks _links;
        public EntertainmentController(IEntertainment entertainment, ILinks links)
        {
            _entertainment = entertainment;
            _links = links;
        }
        [HttpGet]
        [Route("BookList")]
        public List<EntertainmentViewModel> booklist()
        {
            EntertainmentViewModel tolinkobj = new EntertainmentViewModel();
            List<EntertainmentViewModel> tolinklistobj = new List<EntertainmentViewModel>();
            try
            {
                var listEntertainment = _entertainment.EntertainmentBookId();
                foreach (var item in listEntertainment)
                {
                    tolinkobj.TypeId = item.Type;
                    tolinkobj.Name = item.Name;
                    tolinkobj.LinkId = _links.FindById(item.LId).Url;
                    tolinkobj.Galleryid = item.Galleryid;
                    tolinkobj.Title = item.Title;
                    tolinklistobj.Add(tolinkobj);
                }
                return tolinklistobj;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                return tolinklistobj;
            }
        }
        [HttpGet]
        [Route("VideoList")]
        public List<EntertainmentViewModel> VideoList()
        {
            EntertainmentViewModel tolinkobj = new EntertainmentViewModel();
            List<EntertainmentViewModel> tolinklistobj = new List<EntertainmentViewModel>();
            try
            {
                var listEntertainment = _entertainment.entertainmentvideoId();
                foreach (var item in listEntertainment)
                {
                    tolinkobj.TypeId = item.Type;
                    tolinkobj.Name = item.Name;
                    tolinkobj.LinkId = _links.FindById(item.LId).Url;
                    tolinkobj.Galleryid = item.Galleryid;
                    tolinkobj.Title = item.Title;
                    tolinklistobj.Add(tolinkobj);
                }
                return tolinklistobj;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                return tolinklistobj;
            }
        }
        [HttpGet]
        [Route("magazineList")]
        public List<EntertainmentViewModel> magazineList()
        {
            EntertainmentViewModel tolinkobj = new EntertainmentViewModel();
            List<EntertainmentViewModel> tolinklistobj = new List<EntertainmentViewModel>();
            try
            {
                var listEntertainment = _entertainment.entertainmentmagazineId();
                foreach (var item in listEntertainment)
                {
                    tolinkobj.TypeId = item.Type;
                    tolinkobj.Name = item.Name;
                    tolinkobj.LinkId = _links.FindById(item.LId).Url;
                    tolinkobj.Galleryid = item.Galleryid;
                    tolinkobj.Title = item.Title;
                    tolinklistobj.Add(tolinkobj);
                }
                return tolinklistobj;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                return tolinklistobj;
            }
        }
        [HttpGet]
        [Route("AviationList")]
        public List<EntertainmentViewModel> AviationList()
        {
            EntertainmentViewModel tolinkobj = new EntertainmentViewModel();
            List<EntertainmentViewModel> tolinklistobj = new List<EntertainmentViewModel>();
            try
            {
                var listEntertainment = _entertainment.entertainmentAviationid();
                foreach (var item in listEntertainment)
                {
                    tolinkobj.TypeId = item.Type;
                    tolinkobj.Name = item.Name;
                    tolinkobj.LinkId = _links.FindById(item.LId).Url;
                    tolinkobj.Galleryid = item.Galleryid;
                    tolinkobj.Title = item.Title;
                    tolinklistobj.Add(tolinkobj);
                }
                return tolinklistobj;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                return tolinklistobj;
            }
        }

    }
}