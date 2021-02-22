using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using AirPortDataLayer.Crud.InterFace;
using AirPort.Model.ViewModel;

namespace AirPort.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TutorialController : Controller
    {
        private readonly ILinks _link;

        public TutorialController(ILinks links)
        {
            _link = links;
        }
        [HttpGet]
        [Route("tutorialList")]
        public JsonTutorial tutorialList()
        {
            JsonTutorial jsonTutorial = new JsonTutorial();
            List<TutorialViewModel> tutorialLISTOBJ = new List<TutorialViewModel>();
            try
            {
                var tutorialListes = _link.TutorialCategory();
                foreach (var item in tutorialListes)
                {
                    TutorialViewModel tutorialOBJ = new TutorialViewModel();
                    tutorialOBJ.Title = item.Title;
                    tutorialOBJ.Link = item.Url;
                    tutorialOBJ.Description = item.Description;
                    tutorialLISTOBJ.Add(tutorialOBJ);
                }
                jsonTutorial.Result = tutorialLISTOBJ;
                return jsonTutorial;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                return jsonTutorial;
            }
        }
    }
}
