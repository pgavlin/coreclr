using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayIndexOf1_ArrayIndexOf1_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayIndexOf1_ArrayIndexOf1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayIndexOf1\\ArrayIndexOf1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
