using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uintptr_UIntPtrCtor_UInt64_UIntPtrCtor_UInt64_
    {
        [OuterLoop]
        [Fact]
        public void _system_uintptr_UIntPtrCtor_UInt64_UIntPtrCtor_UInt64_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uintptr\\UIntPtrCtor_UInt64\\UIntPtrCtor_UInt64.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
