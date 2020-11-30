using Microsoft.AspNetCore.Mvc;
using System;
using AirPortDataLayer.Crud.InterFace;
using System.Collections.Generic;
using AirPort.Model.ViewModel;
namespace AirPort.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewsController : Controller
    {
        private readonly ILinks _link;

        public NewsController(ILinks links)
        {
            _link = links;
        }
        public List<NewsViewModel> NewsLisr()
        {
            NewsViewModel linknewsobj = new NewsViewModel();
            List<NewsViewModel> linklistobj = new List<NewsViewModel>();
            try
            {
                var ListNews = _link.Listlinks();
                foreach (var item in ListNews)
                {
                    linknewsobj.LinkId = item.Id;
                    linknewsobj.Title = item.Title;
                    linknewsobj.Icon = item.Icon;
                    linklistobj.Add(linknewsobj);
                }
                return linklistobj;
            }
            catch (Exception)
            {
                return linklistobj;
            }
        }
    }
}
