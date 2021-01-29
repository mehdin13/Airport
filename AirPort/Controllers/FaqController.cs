using System;
using AirPort.Model.ViewModel;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AirPort.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FaqController : Controller
    {
        private readonly IFaq _faq;
        public FaqController(IFaq faq)
        {
            _faq = faq;
        }
        [HttpGet]
        [Route("FaqAnimals")]
        public JsonFaq FaqAnimals(int id)
        {
            JsonFaq jsonFaq = new JsonFaq();
            List<FaqViewModel> FaqListObj = new List<FaqViewModel>();
            try
            {
                var Animal = _faq.FaqAnimal();
                foreach (var item in Animal)
                {
                    FaqViewModel faqOBJ = new FaqViewModel();
                    faqOBJ.FaqType = item.FaqType;
                    faqOBJ.Title = item.Title;
                    faqOBJ.Description = item.Description;
                    FaqListObj.Add(faqOBJ);
                }
                jsonFaq.Result = FaqListObj;
                return jsonFaq;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                return jsonFaq;
            }
        }
        [HttpGet]
        [Route("FaqCargo")]
        public JsonFaq FaqCargos(int id)
        {
            JsonFaq jsonFaq = new JsonFaq();
            List<FaqViewModel> FaqListObj = new List<FaqViewModel>();
            try
            {
                var Cargo = _faq.FaqCargo();
                foreach (var item in Cargo)
                {
                    FaqViewModel faqOBJ = new FaqViewModel();
                    faqOBJ.FaqType = item.FaqType;
                    faqOBJ.Title = item.Title;
                    faqOBJ.Description = item.Description;
                    FaqListObj.Add(faqOBJ);
                }
                jsonFaq.Result = FaqListObj;
                return jsonFaq;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                return jsonFaq;
            }
        }
        [HttpGet]
        [Route("FaqClearance")]
        public JsonFaq FaqClearance(int id)
        {
            JsonFaq jsonFaq = new JsonFaq();
            List<FaqViewModel> FaqListObj = new List<FaqViewModel>();
            try
            {
                var Clearance = _faq.FaqClearance();
                foreach (var item in Clearance)
                {
                    FaqViewModel faqOBJ = new FaqViewModel();

                    faqOBJ.FaqType = item.FaqType;
                    faqOBJ.Title = item.Title;
                    faqOBJ.Description = item.Description;
                    FaqListObj.Add(faqOBJ);
                }
                jsonFaq.Result = FaqListObj;
                return jsonFaq;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                return jsonFaq;
            }
        }
    }
}
