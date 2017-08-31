using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _threadpool_bindhandle_bindhandleinvalid_bindhandleinvalid_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _threadpool_bindhandle_bindhandleinvalid_bindhandleinvalid_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\threadpool\\bindhandle\\bindhandleinvalid\\bindhandleinvalid.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
