using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _monitor_ctorchk_ctorchk_ctorchk_
    {
        [OuterLoop]
        [Fact]
        public void _monitor_ctorchk_ctorchk_ctorchk_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\monitor\\ctorchk\\ctorchk\\ctorchk.cmd");
        }
    }
}
