using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_system
{
    class _delegate_miscellaneous_Co6010DelegateEqualsTwo_Co6010DelegateEqualsTwo_
    {
        [OuterLoop]
        [Fact]
        public void _delegate_miscellaneous_Co6010DelegateEqualsTwo_Co6010DelegateEqualsTwo_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\system\\delegate\\miscellaneous\\Co6010DelegateEqualsTwo\\Co6010DelegateEqualsTwo.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
