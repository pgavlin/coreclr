using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayLastIndexOf1_ArrayLastIndexOf1_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayLastIndexOf1_ArrayLastIndexOf1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayLastIndexOf1\\ArrayLastIndexOf1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
