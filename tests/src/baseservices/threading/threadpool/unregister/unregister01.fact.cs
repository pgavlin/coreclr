using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _threadpool_unregister_unregister01_unregister01_
    {
        [OuterLoop]
        [Fact]
        public void _threadpool_unregister_unregister01_unregister01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\threadpool\\unregister\\unregister01\\unregister01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
