using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_delegate_DelegateEquals1_DelegateEquals1_
    {
        [OuterLoop]
        [Fact]
        public void _system_delegate_DelegateEquals1_DelegateEquals1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\delegate\\DelegateEquals1\\DelegateEquals1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
