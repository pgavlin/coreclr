using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayCreateInstance1b_ArrayCreateInstance1b_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayCreateInstance1b_ArrayCreateInstance1b_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayCreateInstance1b\\ArrayCreateInstance1b.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
