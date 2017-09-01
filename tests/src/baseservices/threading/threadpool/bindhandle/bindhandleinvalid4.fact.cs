using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _threadpool_bindhandle_bindhandleinvalid4_bindhandleinvalid4_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _threadpool_bindhandle_bindhandleinvalid4_bindhandleinvalid4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\threadpool\\bindhandle\\bindhandleinvalid4\\bindhandleinvalid4.cmd");
        }
    }
}
