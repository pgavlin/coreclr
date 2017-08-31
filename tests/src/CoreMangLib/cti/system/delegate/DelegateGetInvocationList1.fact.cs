using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_delegate_DelegateGetInvocationList1_DelegateGetInvocationList1_
    {
        [OuterLoop]
        [Fact]
        public void _system_delegate_DelegateGetInvocationList1_DelegateGetInvocationList1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\delegate\\DelegateGetInvocationList1\\DelegateGetInvocationList1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
