using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using RicoCore.Infrastructure.Enums;

namespace RicoCore.Services.Content.Posts.Dtos
{
    public class PostViewModel
    {
        public Guid Id { get; set; }
        public int CategoryId { get; set; }
        public IList<SelectListItem> Categories { set; get; }
        public string CategoryName { get; set; }       

        [StringLength(255)]
        public string Code { set; get; }

        [StringLength(255)]
        public string Url { set; get; }

        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public string Content { get; set; }

        [StringLength(500)]
        public string Image { set; get; }
        public Status Status { set; get; }
        public Status HomeFlag { set; get; }
        public Status HotFlag { set; get; }
   

        public int HotOrder { set; get; }

      

        public int HomeOrder { set; get; }

        public int Viewed { set; get; }

        [StringLength(500)]
        public string Tags { get; set; }       

        public int SortOrder { get; set; }

        [StringLength(70)]
        public string MetaTitle { set; get; }

        [StringLength(500)]
        public string MetaKeywords { set; get; }

        [StringLength(255)]
        public string MetaDescription { set; get; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        public DateTime? DateDeleted { get; set; }
        public bool OrderStatus { set; get; }
        public bool HotOrderStatus { set; get; }
        public bool HomeOrderStatus { set; get; }

        //public PostCategoryViewModel PostCategory { set; get; }

        //public ICollection<PostTagViewModel> PostTags { set; get; }
    }
}