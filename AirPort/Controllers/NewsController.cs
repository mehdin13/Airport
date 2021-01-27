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
        [HttpGet]
        [Route("NewsList")]
        public JsonNews NewsList()
        {
            JsonNews jsonNews = new JsonNews();
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
                jsonNews.Result = linklistobj;
                return jsonNews;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                return jsonNews;
            }
        }
    }
}
