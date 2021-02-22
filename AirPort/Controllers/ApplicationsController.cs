using System;
using AirPort.Model.ViewModel;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AirPort.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApplicationsController : ControllerBase
    {
        private readonly ILinks _links;
        private readonly ICategory _category;
        public ApplicationsController(ILinks links,ICategory category)
        {
            _links = links;
            _category = category;
        }
        [HttpGet]
        [Route("Applist")]
        public JsonApplication Applist()
        {
            List<LinkViewModel> linklistobj = new List<LinkViewModel>();
            JsonApplication jsonApplication = new JsonApplication();
            try
            {
                var App = _links.ApplicationCategory();
                foreach (var item in App)
                {
                   
                    LinkViewModel linkOBJ = new LinkViewModel();
                    linkOBJ.Name = item.Title;
                    linkOBJ.Icon = item.Icon;
                    linkOBJ.UrL = item.Url;
                    linklistobj.Add(linkOBJ);
                }
                jsonApplication.Result = linklistobj;
                return jsonApplication;
            }
            catch (Exception ex)
            {
                string Mes = ex.Message;
                return jsonApplication;
            }
        }
    }
}
