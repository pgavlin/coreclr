using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_system
{
    class _delegate_miscellaneous_Co6031GetHashCode_Co6031GetHashCode_
    {
        [OuterLoop]
        [Fact]
        public void _delegate_miscellaneous_Co6031GetHashCode_Co6031GetHashCode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\system\\delegate\\miscellaneous\\Co6031GetHashCode\\Co6031GetHashCode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
