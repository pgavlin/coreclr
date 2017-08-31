using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_int64_Int64CompareTo1_Int64CompareTo1_
    {
        [OuterLoop]
        [Fact]
        public void _system_int64_Int64CompareTo1_Int64CompareTo1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\int64\\Int64CompareTo1\\Int64CompareTo1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
