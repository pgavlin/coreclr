using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayLastIndexOf4_ArrayLastIndexOf4_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayLastIndexOf4_ArrayLastIndexOf4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayLastIndexOf4\\ArrayLastIndexOf4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
