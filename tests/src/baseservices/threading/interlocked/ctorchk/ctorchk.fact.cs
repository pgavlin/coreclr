using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_ctorchk_ctorchk_ctorchk_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_ctorchk_ctorchk_ctorchk_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\ctorchk\\ctorchk\\ctorchk.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
