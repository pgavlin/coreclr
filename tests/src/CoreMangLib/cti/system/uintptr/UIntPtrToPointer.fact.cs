using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uintptr_UIntPtrToPointer_UIntPtrToPointer_
    {
        [OuterLoop]
        [Fact]
        public void _system_uintptr_UIntPtrToPointer_UIntPtrToPointer_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uintptr\\UIntPtrToPointer\\UIntPtrToPointer.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
