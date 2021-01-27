using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using AirPortDataLayer.Crud.InterFace;
using AirPort.Model.ViewModel;

namespace AirPort.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticlController : Controller
    {
        private readonly IArticle _db;

        public ArticlController (IArticle db)
        {
            _db = db;
        }
        [HttpGet]
        [Route("ArticleList")]
        public JsonArticle ArticleList()
        {
            JsonArticle jsonArticle = new JsonArticle();
            ArticleviewModel articleLinkObj = new ArticleviewModel();
            List<ArticleviewModel> artikleLinkListObj = new List<ArticleviewModel>();

            try
            {
                var ListArticle = _db.ToList();
                foreach (var item in ListArticle)
                {
                    articleLinkObj.Title = item.Title;
                    articleLinkObj.Description = item.Description;
                    articleLinkObj.GalleryId = item.GalleryId;
                    artikleLinkListObj.Add(articleLinkObj);
                }
                jsonArticle.Result = artikleLinkListObj;
                return jsonArticle;
            }
            catch (Exception ex)
            {
                _= ex.Message;
                return jsonArticle;
            }
        }
    }
}
