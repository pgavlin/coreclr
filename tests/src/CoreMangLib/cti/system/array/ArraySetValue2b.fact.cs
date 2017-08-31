using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArraySetValue2b_ArraySetValue2b_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArraySetValue2b_ArraySetValue2b_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArraySetValue2b\\ArraySetValue2b.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
