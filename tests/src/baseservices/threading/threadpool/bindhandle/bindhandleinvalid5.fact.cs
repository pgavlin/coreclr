using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _threadpool_bindhandle_bindhandleinvalid5_bindhandleinvalid5_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _threadpool_bindhandle_bindhandleinvalid5_bindhandleinvalid5_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\threadpool\\bindhandle\\bindhandleinvalid5\\bindhandleinvalid5.cmd");
        }
    }
}
