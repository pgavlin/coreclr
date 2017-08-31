using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_int64_Int64Equals2_Int64Equals2_
    {
        [OuterLoop]
        [Fact]
        public void _system_int64_Int64Equals2_Int64Equals2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\int64\\Int64Equals2\\Int64Equals2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
