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
        public ApplicationsController(ILinks links)
        {
            _links = links;
        }
        [HttpGet]
        [Route("Applist")]
        public JsonApplication Applist()
        {
            List<LinkViewModel> linklistobj = new List<LinkViewModel>();
            JsonApplication jsonApplication = new JsonApplication();
            try
            {
                var links = _links.ToList();
                foreach (var item in links)
                {
                    if (item.Type==3)
                    {

                    LinkViewModel linkOBJ = new LinkViewModel();
                    linkOBJ.Name = item.Title;
                    linkOBJ.Icon = item.Icon;
                    linkOBJ.UrL = item.Url;
                    linklistobj.Add(linkOBJ);
                    }
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
