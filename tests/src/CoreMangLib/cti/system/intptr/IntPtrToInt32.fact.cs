using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_intptr_IntPtrToInt32_IntPtrToInt32_
    {
        [OuterLoop]
        [Fact]
        public void _system_intptr_IntPtrToInt32_IntPtrToInt32_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\intptr\\IntPtrToInt32\\IntPtrToInt32.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
