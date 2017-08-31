using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArraySetValue1b_ArraySetValue1b_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArraySetValue1b_ArraySetValue1b_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArraySetValue1b\\ArraySetValue1b.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
