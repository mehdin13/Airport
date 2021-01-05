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
        public JsonEntertainment booklist()
        {
            JsonEntertainment jsonEntertainment = new JsonEntertainment();
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
                jsonEntertainment.Result = tolinklistobj;
                return jsonEntertainment;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                return jsonEntertainment;
            }
        }
        [HttpGet]
        [Route("VideoList")]
        public JsonEntertainment VideoList()
        {
            JsonEntertainment jsonEntertainment = new JsonEntertainment();
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
                jsonEntertainment.Result = tolinklistobj;
                return jsonEntertainment;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                return jsonEntertainment;
            }
        }
        [HttpGet]
        [Route("magazineList")]
        public JsonEntertainment magazineList()
        {
            JsonEntertainment jsonEntertainment = new JsonEntertainment();
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
                jsonEntertainment.Result = tolinklistobj;
                return jsonEntertainment;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                return jsonEntertainment;
            }
        }
        [HttpGet]
        [Route("AviationList")]
        public JsonEntertainment AviationList()
        {
            JsonEntertainment jsonEntertainment = new JsonEntertainment();
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
                jsonEntertainment.Result = tolinklistobj;
                return jsonEntertainment;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                return jsonEntertainment;
            }
        }

    }
}