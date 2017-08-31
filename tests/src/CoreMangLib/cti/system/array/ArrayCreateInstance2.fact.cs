using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayCreateInstance2_ArrayCreateInstance2_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayCreateInstance2_ArrayCreateInstance2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayCreateInstance2\\ArrayCreateInstance2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
