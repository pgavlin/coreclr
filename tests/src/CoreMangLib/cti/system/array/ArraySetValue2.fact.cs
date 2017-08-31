using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArraySetValue2_ArraySetValue2_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArraySetValue2_ArraySetValue2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArraySetValue2\\ArraySetValue2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
