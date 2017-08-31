using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uintptr_UIntPtrZero_UIntPtrZero_
    {
        [OuterLoop]
        [Fact]
        public void _system_uintptr_UIntPtrZero_UIntPtrZero_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uintptr\\UIntPtrZero\\UIntPtrZero.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
