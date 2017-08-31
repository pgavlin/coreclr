using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uintptr_UIntPtrGetHashCode_UIntPtrGetHashCode_
    {
        [OuterLoop]
        [Fact]
        public void _system_uintptr_UIntPtrGetHashCode_UIntPtrGetHashCode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uintptr\\UIntPtrGetHashCode\\UIntPtrGetHashCode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
