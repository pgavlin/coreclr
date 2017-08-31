using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayCopyTo_ArrayCopyTo_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayCopyTo_ArrayCopyTo_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayCopyTo\\ArrayCopyTo.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
