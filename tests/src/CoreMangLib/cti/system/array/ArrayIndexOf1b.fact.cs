using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayIndexOf1b_ArrayIndexOf1b_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayIndexOf1b_ArrayIndexOf1b_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayIndexOf1b\\ArrayIndexOf1b.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
