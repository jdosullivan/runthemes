﻿using System.Collections.Generic;
using AutoMapper;
using WhiteLabel.Business.Services;
using WhiteLabel.Data.Models;
using WhiteLabel.Web.ViewModels;

namespace WhiteLabel.Web.AutoMappings.Resolvers
{
    public class PostCommentsResolver : ValueResolver<Post, IEnumerable<PostCommentViewModel>>
    {
        private readonly IPostCommentService postCommentService;
        private readonly IMappingEngine mappingEngine;
        public PostCommentsResolver(IPostCommentService postCommentService, IMappingEngine mappingEngine)
        {
            this.postCommentService = postCommentService;
            this.mappingEngine = mappingEngine;
        }

        protected override IEnumerable<PostCommentViewModel> ResolveCore(Post post)
        {
            var postComments = postCommentService.GetForPost(post.PostId);
            return mappingEngine.Map<IEnumerable<PostComment>, IEnumerable<PostCommentViewModel>>(postComments);
        }
    }
}