using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Title can not empty.");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog Image can not empty ");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog content can not empty");
        }


    }
}
