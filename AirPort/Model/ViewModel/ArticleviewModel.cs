using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirPort.Model.ViewModel
{
    public class ArticleviewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int GalleryId { get; set; }
    }
    public class JsonArticle
    {
        public List<ArticleviewModel> Result { get; set; }
    }
}
