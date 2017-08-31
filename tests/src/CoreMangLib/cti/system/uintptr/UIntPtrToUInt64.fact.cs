using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uintptr_UIntPtrToUInt64_UIntPtrToUInt64_
    {
        [OuterLoop]
        [Fact]
        public void _system_uintptr_UIntPtrToUInt64_UIntPtrToUInt64_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uintptr\\UIntPtrToUInt64\\UIntPtrToUInt64.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
