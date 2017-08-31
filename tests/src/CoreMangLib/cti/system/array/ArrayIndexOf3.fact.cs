using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayIndexOf3_ArrayIndexOf3_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayIndexOf3_ArrayIndexOf3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayIndexOf3\\ArrayIndexOf3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
