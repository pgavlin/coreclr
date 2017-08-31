using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_intptr_IntPtrToInt64_IntPtrToInt64_
    {
        [OuterLoop]
        [Fact]
        public void _system_intptr_IntPtrToInt64_IntPtrToInt64_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\intptr\\IntPtrToInt64\\IntPtrToInt64.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
