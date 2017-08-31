using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayLastIndexOf1b_ArrayLastIndexOf1b_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayLastIndexOf1b_ArrayLastIndexOf1b_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayLastIndexOf1b\\ArrayLastIndexOf1b.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
