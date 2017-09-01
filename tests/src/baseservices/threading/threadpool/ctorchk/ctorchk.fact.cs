using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _threadpool_ctorchk_ctorchk_ctorchk_
    {
        [OuterLoop]
        [Fact]
        public void _threadpool_ctorchk_ctorchk_ctorchk_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\threadpool\\ctorchk\\ctorchk\\ctorchk.cmd");
        }
    }
}
