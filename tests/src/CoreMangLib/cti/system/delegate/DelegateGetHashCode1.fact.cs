using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_delegate_DelegateGetHashCode1_DelegateGetHashCode1_
    {
        [OuterLoop]
        [Fact]
        public void _system_delegate_DelegateGetHashCode1_DelegateGetHashCode1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\delegate\\DelegateGetHashCode1\\DelegateGetHashCode1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
