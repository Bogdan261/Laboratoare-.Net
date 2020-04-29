using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using PostComment;

namespace GrpcGreeter
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }
        
        public override Task<msgBool> AddPost(msgPost request, ServerCallContext context)
        {
            Post post = new Post();
            post.PostId = request.PostId;
            post.Description = request.Description;
            post.Domain = request.Domain;
            post.Date = request.Date;
            bool resulted=PostComment.APIStatic.API.AddPost(post);

            return Task.FromResult(new msgBool
            {
               Result = resulted
            }); 
        }

        public override Task<msgPost> UpdatePost(msgPost request, ServerCallContext context)
        {
            Post post = new Post();
            post.PostId = request.PostId;
            post.Description = request.Description;
            post.Domain = request.Domain;
            post.Date = request.Date;
            Post result = PostComment.APIStatic.API.UpdatePost(post);
            return Task.FromResult(new msgPost
            {
                PostId = result.PostId,
                Description = result.Description,
                Domain = result.Domain,
                Date = result.Date
            }) ;
        }

        public override Task<msgInt> DeletePost(msgId request, ServerCallContext context)
        {
           int result = PostComment.APIStatic.API.DeletePost(request.Id);

            return Task.FromResult(new msgInt
            {
              Value=result
            });
        }

        public override Task<msgPost> GetPostById(msgId request, ServerCallContext context)
        {
            Post result= PostComment.APIStatic.API.GetPostById(request.Id);
            return Task.FromResult(new msgPost
            {
                PostId = result.PostId,
                Description = result.Description,
                Domain = result.Domain,
                Date = result.Date

            });
        }

        public override Task<msgPosts> GetAllPosts(msgVoid request, ServerCallContext context)
        {
            List<Post> result= PostComment.APIStatic.API.GetAllPosts(request.Id);
            return Task.FromResult(new msgPosts
            {
                // aici nu am stiut cum sa returnez valori multiple


            });

        }

        public override Task<msgBool> AddComment(msgComment request, ServerCallContext context)
        {
            Comment comment = new Comment();
            comment.CommentId = request.CommentId;
            comment.Text = request.Text;
            comment.PostPostId = request.PostPostId;
            bool resulted= PostComment.APIStatic.API.AddComment(comment);
            return Task.FromResult(new msgBool
            {
                result=resulted
            });

        }

        public override Task<msgComment> UpdateComment(msgComment request, ServerCallContext context)
        {
            Comment comment = new Comment();
            comment.CommentId = request.CommentId;
            comment.Text = request.Text;
            comment.PostPostId = request.PostPostId;
            Comment result=PostComment.APIStatic.API.UpdateComment(comment);
            return Task.FromResult(new msgComment
            {
                CommentId = result.CommentId,
                Text=result.Text,
                PostPostId=result.PostPostId

            }) ;


        }

        public override Task<msgComment> GetCommentById(msgId request, ServerCallContext context)
        {
            Comment result= PostComment.APIStatic.API.GetCommentById(request.Id);
            return Task.FromResult(new msgComment
            {
                CommentId = result.CommentId,
                Text = result.Text,
                PostPostId = result.PostPostId

            });
        }
    }
}
