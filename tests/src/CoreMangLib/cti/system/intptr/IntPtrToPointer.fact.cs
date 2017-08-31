using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_intptr_IntPtrToPointer_IntPtrToPointer_
    {
        [OuterLoop]
        [Fact]
        public void _system_intptr_IntPtrToPointer_IntPtrToPointer_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\intptr\\IntPtrToPointer\\IntPtrToPointer.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
