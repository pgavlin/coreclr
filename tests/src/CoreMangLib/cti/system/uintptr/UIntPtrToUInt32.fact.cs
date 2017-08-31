using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uintptr_UIntPtrToUInt32_UIntPtrToUInt32_
    {
        [OuterLoop]
        [Fact]
        public void _system_uintptr_UIntPtrToUInt32_UIntPtrToUInt32_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uintptr\\UIntPtrToUInt32\\UIntPtrToUInt32.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
