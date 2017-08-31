using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_int64_Int64GetHashCode_Int64GetHashCode_
    {
        [OuterLoop]
        [Fact]
        public void _system_int64_Int64GetHashCode_Int64GetHashCode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\int64\\Int64GetHashCode\\Int64GetHashCode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
