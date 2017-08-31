using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _threadpool_bindhandle_bindhandleinvalid6_bindhandleinvalid6_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _threadpool_bindhandle_bindhandleinvalid6_bindhandleinvalid6_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\threadpool\\bindhandle\\bindhandleinvalid6\\bindhandleinvalid6.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
