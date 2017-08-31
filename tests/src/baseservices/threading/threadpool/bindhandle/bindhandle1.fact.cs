using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _threadpool_bindhandle_bindhandle1_bindhandle1_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _threadpool_bindhandle_bindhandle1_bindhandle1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\threadpool\\bindhandle\\bindhandle1\\bindhandle1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
