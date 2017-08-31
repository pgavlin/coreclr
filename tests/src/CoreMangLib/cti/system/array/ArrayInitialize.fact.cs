using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayInitialize_ArrayInitialize_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayInitialize_ArrayInitialize_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayInitialize\\ArrayInitialize.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
