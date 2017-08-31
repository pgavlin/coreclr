using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayCopy2_ArrayCopy2_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayCopy2_ArrayCopy2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayCopy2\\ArrayCopy2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
