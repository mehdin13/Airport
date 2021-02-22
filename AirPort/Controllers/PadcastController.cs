using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using AirPortDataLayer.Crud.InterFace;
using AirPort.Model.ViewModel;

namespace AirPort.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PadcastController : Controller
    {
        private readonly ILinks _link;
        private readonly ICategory _category;

        public PadcastController(ILinks links,ICategory category)
        {
            _link = links;
            _category = category;
        }
        [HttpGet]
        [Route("PadcastLIst")]
        public JsonPadcast PadcastLIst()
        {
            JsonPadcast jsonPadcast = new JsonPadcast();
            List<PadcastViewModel> PadcastListOBJ = new List<PadcastViewModel>();
            try
            {
                var Padcasts = _link.LinkType();
                foreach (var item in Padcasts)
                {
                    PadcastViewModel padcastOBJ = new PadcastViewModel();
                    padcastOBJ.Title = item.Title;
                    padcastOBJ.Link = item.Url;
                    padcastOBJ.Description = item.Description;                   
                    PadcastListOBJ.Add(padcastOBJ);
                }
                jsonPadcast.Result = PadcastListOBJ;
                return jsonPadcast;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                return jsonPadcast;
            }
        }

    }
}
