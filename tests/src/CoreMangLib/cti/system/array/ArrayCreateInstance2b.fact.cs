using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayCreateInstance2b_ArrayCreateInstance2b_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayCreateInstance2b_ArrayCreateInstance2b_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayCreateInstance2b\\ArrayCreateInstance2b.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
