using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _threadpool_ctorchk_ctorchk_ctorchk_
    {
        [OuterLoop]
        [Fact]
        public void _threadpool_ctorchk_ctorchk_ctorchk_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\threadpool\\ctorchk\\ctorchk\\ctorchk.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
