using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uintptr_UIntPtrSize_UIntPtrSize_
    {
        [OuterLoop]
        [Fact]
        public void _system_uintptr_UIntPtrSize_UIntPtrSize_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uintptr\\UIntPtrSize\\UIntPtrSize.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
