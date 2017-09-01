using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_ctorchk_ctorchk_ctorchk_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_ctorchk_ctorchk_ctorchk_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\ctorchk\\ctorchk\\ctorchk.cmd");
        }
    }
}
