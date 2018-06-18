using System;
using KenticoCloud.Delivery;

namespace CloudIntegration.Models
{
    public class CustomTypeProvider : ICodeFirstTypeProvider
    {
        public Type GetType(string contentType)
        {
            switch (contentType)
            {
                case "article":
                    return typeof(Article);
                case "block":
                    return typeof(Block);
                case "component":
                    return typeof(Component);
                case "course_metadata":
                    return typeof(CourseMetadata);
                case "page":
                    return typeof(Page);
                default:
                    return null;
            }
        }
    }
}