using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayCopy1_ArrayCopy1_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayCopy1_ArrayCopy1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayCopy1\\ArrayCopy1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
