using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _threadpool_bindhandle_bindhandleinvalid6_bindhandleinvalid6_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _threadpool_bindhandle_bindhandleinvalid6_bindhandleinvalid6_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\threadpool\\bindhandle\\bindhandleinvalid6\\bindhandleinvalid6.cmd");
        }
    }
}
