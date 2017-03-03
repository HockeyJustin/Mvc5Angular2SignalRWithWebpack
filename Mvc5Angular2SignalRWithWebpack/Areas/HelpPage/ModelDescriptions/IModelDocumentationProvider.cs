using System;
using System.Reflection;

namespace Mvc5Angular2SignalRWithWebpack.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}