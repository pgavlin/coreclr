using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _threadpool_unregister_unregister03_unregister03_
    {
        [OuterLoop]
        [Fact]
        public void _threadpool_unregister_unregister03_unregister03_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\threadpool\\unregister\\unregister03\\unregister03.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
